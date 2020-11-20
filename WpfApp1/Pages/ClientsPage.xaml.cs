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
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        List<Client> clients { get; set; }
        public ClientsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            clients = MainWindow.HermesDB.Client.ToList();
            ClientsDataGrid.ItemsSource = clients;
        }

        private void Refresh() 
        {
            if (String.IsNullOrEmpty(NameTB.Text) || String.IsNullOrEmpty(NameTB.Text) || String.IsNullOrEmpty(NameTB.Text))
            {
                clients.Where(x => x.Firstname.ToUpper().Contains(NameTB.Text));
            }
        }

        private void NameTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
