using Oico.Data;
using Oico.Data.DTO.Requests;
using Oico.Data.DTO.Responses;
using Oico.Data.Repositories;
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

namespace Oico.Desktop
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        IAdminRepository adminRepo = new AdminRepository();

        public Login()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            AdminLoginRequest request = new AdminLoginRequest
            {
                Username = UsernameTxt.Text,
                Password = PasswordTxt.Password
            };

            BaseResponse response = await adminRepo.Login(request);

            if (response.Success)
            {
                MainWindow window = new MainWindow();
                window.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show(response.Errors.ToList()[0].ToString(), "Xatolik", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
