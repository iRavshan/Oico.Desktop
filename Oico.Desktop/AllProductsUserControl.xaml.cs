using Oico.Data.API;
using Oico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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
    /// Interaction logic for AllProductsUserControl.xaml
    /// </summary>
    public partial class AllProductsUserControl : UserControl
    {
        public AllProductsUserControl()
        {
            InitializeComponent();
        }

        private async void AllProductsUserControl_Loaded(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            IEnumerable<Product> Products = await client.GetFromJsonAsync<Product[]>(ProductAPI.GetAll);
            ProductsDataGrid.ItemsSource = Products;
        }
    }
}
