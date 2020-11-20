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
using WpfApp1.Data;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void RememberCB_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Login = LoginTB.Text;
            Properties.Settings.Default.Save();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Login)) 
            {
                LoginTB.Text = Properties.Settings.Default.Login;
                RememberCB.IsChecked = true;
            }
        }

        private void RememberCB_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Login = null;
            Properties.Settings.Default.Save();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {            if (MainWindow.HermesDB.User.Where(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Password) != null)
                this.NavigationService.Navigate(new ClientsPage());
            else
                MessageBox.Show("Неправельный логин или пароль");
        }
    }
}
