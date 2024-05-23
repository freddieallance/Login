using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using RestSharp;

namespace SampleWPF
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        //private readonly ViewModel viewModel;
        public Page1()
        {
            InitializeComponent();

            List<DataGridItem> staffDetails = new List<DataGridItem>();

            SqliteConnection m_dbConnection;
            m_dbConnection = new SqliteConnection("Data Source=C:\\SAINS\\SampleWPF\\sampleDatabase.sqlite");
            m_dbConnection.Open();

            SqliteDataReader dataReader;
            SqliteCommand cmd;
            cmd = m_dbConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM staff";

            dataReader = cmd.ExecuteReader();

            //if table has any rows
            if(dataReader.HasRows)
            {

                //for each row
                while(dataReader.Read())
                {
                    //create an instance of DataGridItem
                    var staffData = new DataGridItem();

                    //if staff_id column is not empty then assign column value to staffData object 
                    if(!dataReader.IsDBNull(0))
                    {
                        staffData.staff_id = dataReader["staff_id"].ToString();
                    }

                    //if name column is not empty then assign column value to staffData object 
                    if (!dataReader.IsDBNull(1))
                    {
                        staffData.name = dataReader["name"].ToString(); //ConvertToInt32
                    }

                    //if division column is not empty then assign column value to staffData object 
                    if (!dataReader.IsDBNull(2))
                    {
                        staffData.division = dataReader["division"].ToString();
                    }

                    staffDetails.Add(staffData);
                }
            }

            //assign staffDetails List as data source for data grid (table) to refer to
            this.dataGrid1.ItemsSource = staffDetails;

        }

        private async void callApi(object sender, RoutedEventArgs e)
        {
            //create new instance of DataGrid class and assign currently selected row values in data grid (table)
            DataGridItem dgItem = dataGrid1.SelectedItem as DataGridItem;

            //if row is not null
            if(dgItem != null)
            {
                Console.WriteLine($"Staff Name is : {dgItem.name}");
                var task = GetGenderAPI(dgItem.name);
                var gender = await task;
                MessageBox.Show($"Selected Staff is a {gender}");
            }
            else
            {
                Console.WriteLine("Its null");
            }
        }

        public async Task<string> GetGenderAPI(string name)
        {
            //API that guesses gender
            var url = $"http://api.genderize.io?name={name}";
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(url, Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            var output = response.Content;

            string staffGender = "";

            APIData data = new APIData();
            //deserialize content of response into json readeable format
            if (output != null)
            {
                data = JsonConvert.DeserializeObject<APIData>(output);
                staffGender = data.gender;
            }
            else
            {
                staffGender = "Unknown";
            }
            
            
            return staffGender;
        }

    }
}
