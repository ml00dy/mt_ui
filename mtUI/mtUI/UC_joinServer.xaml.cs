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

namespace mtUI
{
    /// <summary>
    /// Interaction logic for UC_joinServer.xaml
    /// </summary>
    public partial class UC_joinServer : UserControl
    {
        double maxH = 400;
        double minH = 50;
        string tempText = "Put secret code here ... ";

        public UC_joinServer()
        {
            InitializeComponent();

            uc_join.Height = 50;
            tb_code.Text = tempText;
          //  button.Content = uc_join.Height.ToString();
            addSomeServers();
            tb_code.IsEnabled = false;

        }


        private void btn_MAIN_join_Click(object sender, RoutedEventArgs e)
        { 
            uc_join.Height = uc_join.Height == minH ? maxH : minH;

            // button.Content = uc_join.Height.ToString();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
            {
                dg_serverList.IsEnabled = false;
                tb_code.IsEnabled = true;
            }
            else if (checkBox.IsChecked == false)
            {
                dg_serverList.IsEnabled = true;
                tb_code.IsEnabled = false;
            }
        }


        private void addSomeServers()
        {
            Random rnd = new Random();
            Random rnd_s = new Random();
            for(int i = 0; i < rnd_s.Next(10, 1000); i++)
            {
                string s = "Cyberpunk 2077 server no. " + i.ToString();
                dg_serverList.Items.Add(new { Name = s, add = (rnd.Next(6000, 10000)).ToString() });
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            string info = "";
            if (dg_serverList.IsEnabled == true)
            {
                info = dg_serverList.SelectedItem.ToString();
            }
            else if(tb_code.IsEnabled == true)
                info = tb_code.Text.ToString();

            MessageBox.Show("Joining session: " + Environment.NewLine + info, "Info", MessageBoxButton.OK);
        }


    }
}
