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
    /// Interaction logic for UC_createServer.xaml
    /// </summary>
    public partial class UC_createServer : UserControl
    {
        double maxH = 250;
        double minH = 50;
        double maxHWP = 420;

        public UC_createServer()
        {
            InitializeComponent();
            cmb_howmany.Visibility = Visibility.Hidden;
            lb_howmany.Visibility = Visibility.Hidden;
            tb_bots.Visibility = Visibility.Hidden;
            uc_create.Height = minH;
        }

        private void button_Click(object sender, MouseButtonEventArgs e)
        {
            if (uc_create.Height == minH)
            {
                uc_create.Height = maxH;
            }
            else if (uc_create.Height == maxH || uc_create.Height == maxHWP)
                uc_create.Height = minH;
            else if (cb_spawn.IsChecked == true)
                uc_create.Height = maxHWP;

            //button.Content = uc_create.Height.ToString();
        }

        private void cb_spawn_Click(object sender, RoutedEventArgs e)
        {
            if (cb_spawn.IsChecked == true)
            {
                uc_create.Height = maxHWP;
                cmb_howmany.Visibility = Visibility.Visible;
                lb_howmany.Visibility = Visibility.Visible;
                tb_bots.Visibility = Visibility.Visible;
            }
            else if (cb_spawn.IsChecked == false)
            {
                cmb_howmany.Visibility = Visibility.Hidden;
                lb_howmany.Visibility = Visibility.Hidden;
                tb_bots.Visibility = Visibility.Hidden;
                uc_create.Height = maxH;
            }
        }

        private void cmb_howmany_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (TabItem tabItem in tb_bots.Items)
            {
                tb_bots.Items.Remove(tabItem);
            }

            ComboBoxItem t = (ComboBoxItem)cmb_howmany.SelectedItem;
            string content = t.Content.ToString();
            int count = Convert.ToInt32(content);


            for (int i = 1; i <= count; i++)
            {
                TabItem tp = new TabItem
                {
                    Header = "Bot " + i
                };

                tb_bots.Items.Add(tp);
            }

        }

        private void btn_create_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Creating server now ... ", "Info", MessageBoxButton.OK);
        }

        private void test(object sender, RoutedEventArgs e)
        {
            if (uc_create.Height == minH)
            {
                uc_create.Height = maxH;
            }
            else if (uc_create.Height == maxH || uc_create.Height == maxHWP)
                uc_create.Height = minH;
            else if (cb_spawn.IsChecked == true)
                uc_create.Height = maxHWP;
        }
    }
}
