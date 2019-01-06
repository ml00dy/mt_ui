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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            addControls();
        }

        private void addControls()
        {
            UC_joinServer ucjoin = new UC_joinServer();
            UC_createServer uccreate = new UC_createServer();

            List<UserControl> listtojoin = new List<UserControl>();
            listtojoin.Add(ucjoin);
            listtojoin.Add(uccreate);


            foreach (UserControl uc in listtojoin)
            {
                ST_Main.Children.Add(uc);
            }
        }

        private void Main_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
