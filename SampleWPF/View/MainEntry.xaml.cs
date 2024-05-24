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
using System.Windows.Shapes;

namespace SampleWPF.View
{
    /// <summary>
    /// Interaction logic for MainEntry.xaml
    /// </summary>
    public partial class MainEntry : Window
    {
        public MainEntry()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SideEntry newWindow = new SideEntry();
            newWindow.Show();
            
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
