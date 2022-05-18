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

namespace Oico.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            HomeUserControl userControl = new HomeUserControl();
            MainPanel.Children.Clear();
            MainPanel.Children.Add(userControl);
        }

        private void AllProductsBtn_Click(object sender, RoutedEventArgs e)
        {
            AllProductsUserControl userControl = new AllProductsUserControl();
            MainPanel.Children.Clear();
            MainPanel.Children.Add(userControl);
        }
    }
}
