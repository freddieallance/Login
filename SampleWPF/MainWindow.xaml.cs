using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
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
using MySql.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SampleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //When page is loaded we create the sqlite database
            //CreateSqliteDB();
        }

        private void saveBtnClick(object sender, RoutedEventArgs e)
        {
            //create variables and assign textbox values to them
            string userID = userIDTxtBox.Text;
            string upassword = passwordTxtBox.Text;
            //string staffDivision = divTxtBox.Text;

            //if all textbox are not null or empty then
            //if (!string.IsNullOrEmpty(staffID) && !string.IsNullOrEmpty(staffName) && !string.IsNullOrEmpty(staffDivision))
            if (!string.IsNullOrEmpty(userID) && !string.IsNullOrEmpty(upassword))
            {

                //if saving to sqlite db is succesful then
                /*if(saveToSqliteDB(staffID, staffName, staffDivision))
                {
                    //show pop up window with message
                    MessageBox.Show("Staff data successfully inserted to sqlite database");

                    //Clear text boxes
                    staffIDTxtBox.Clear();
                    nameTxtBox.Clear();
                    divTxtBox.Clear();*/

                //if(savetoMySqlDB(staffID, staffName, staffDivision))
                if (savetoMySqlDB(userID))
                {
                        MessageBox.Show("User successfully login!");
                        NavigationFrame.Content = new Page1();
                }
                else
                {
                        MessageBox.Show("Failed to login!");

                }/*
                }
                else
                {
                    MessageBox.Show("Failed to insert to sqlite database");
                }*/
            }
            else
            {
                MessageBox.Show("One or more neccessary fields is empty");
            }
        }

        /*public void CreateSqliteDB()
        {
            SqliteConnection m_dbConnection;
            m_dbConnection = new SqliteConnection("Data Source=C:\\SAINS\\SampleWPF\\sampleDatabase.sqlite"); //this creates the sqlite db file if it doesn't already exist
            m_dbConnection.Open();

            SqliteCommand command;
            command = m_dbConnection.CreateCommand();
            command.CommandText = "CREATE TABLE IF NOT EXISTS staff (staff_id VARCHAR PRIMARY KEY, name VARCHAR, division VARCHAR)";
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }*/

        /*public bool saveToSqliteDB(string id, string name, string division)
        {
            try
            {
                SqliteConnection m_dbConnection;
                m_dbConnection = new SqliteConnection("Data Source=C:\\SAINS\\SampleWPF\\sampleDatabase.sqlite");
                m_dbConnection.Open();

                SqliteCommand command;
                command = m_dbConnection.CreateCommand();
                command.CommandText = "INSERT INTO staff (staff_id, name, division) VALUES (@param1, @param2, @param3)";

                command.Parameters.AddWithValue("@param1", id);
                command.Parameters.AddWithValue("@param2", name);
                command.Parameters.AddWithValue("@param3", division);
                command.ExecuteNonQuery();

                m_dbConnection.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }*/

        public bool savetoMySqlDB(string sid)
        {
            bool saved = false;
            
            try
            {
                /*MessageBox.Show("In try");
                MySqlConnection conn = new MySqlConnection("Data Source=172.26.80.150;port=3306;Database=Ela_DB;Username=rbs;password=rbsdbadmin");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select userpassword from system_logon where userid=@id", conn);
                cmd.Parameters.AddWithValue("id", staffIDTxtBox.Text.Trim());
                MySqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                MessageBox.Show("After execute");
                if (myreader.Read())
                {
                    MessageBox.Show("In read");
                    nameTxtBox.Text = myreader["userpassword"].ToString();
                    saved = true;
                }
                else
                {
                    MessageBox.Show("In else");
                    nameTxtBox.Text = "";
                }
                conn.Close();*/

                string connectionString = "server=172.26.80.150;port=3306;username=rbs;password=rbsdbadmin;database=Ela_DB;CharSet=utf8;SSL Mode=None;AllowPublicKeyRetrieval=true";

                //string query = "INSERT INTO staff (staff_id , name, division) VALUES (@param1, @param2, @param3)";
                string query = "SELECT userpassword from system_logon where userid=@param1";

                MySqlDataReader myReader;

                using (MySqlConnection myConn = new MySqlConnection(connectionString))
                {
                    myConn.Open();
                    using (MySqlCommand mycommand = new MySqlCommand(query, myConn))
                    {
                        mycommand.Parameters.AddWithValue("@param1", sid);
                        //mycommand.Parameters.AddWithValue("@param2", spassword);
                        //mycommand.Parameters.AddWithValue("@param3", division);

                        myReader = mycommand.ExecuteReader();

                        if (myReader.Read()) {
                            userIDTxtBox.Text = myReader["userpassword"].ToString();
                        }
                        else
                        {
                            userIDTxtBox.Text = "";
                            passwordTxtBox.Text = "";
                            MessageBox.Show("No data found!");
                        }

                        myReader.Close();
                    }
                    myConn.Close();

                }

                saved = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                saved = false;
            }

            return saved;
        }

        /*private void showStaff(object sender, RoutedEventArgs e)
        {
            
            //Change the content of the frame to new page
            NavigationFrame.Content = new Page1();
        }*/
    }
}
