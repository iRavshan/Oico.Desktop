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
    /// Interaction logic for HomeUserControl.xaml
    /// </summary>
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            InfoToday.Content = DateTime.Now.ToString("dd.MM.yyyy");
            InfoWeek.Content = DateTime.Now.ToString("dd.MM.yyyy") + " - " + DateTime.Now.AddDays(6).ToString("dd.MM.yyyy");
            InfoMonth.Content = DateTime.Now.ToString("MMMM");
            InfoYear.Content = DateTime.Now.ToString("yyyy");
        }
    }
}
