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
using FirstProject.Pages;
using FirstProject.Model;

namespace FirstProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Page
    {
        public AddService(Service service)
        {
            InitializeComponent();
            ExcessImageList.ItemsSource = App.DB.Service.ToList();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddImageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LeftBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddIngBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteIngBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
