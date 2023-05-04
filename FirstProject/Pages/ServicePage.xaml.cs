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
using System.Data.Entity;

namespace FirstProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();
            ServiceList.ItemsSource = App.DB.Service.ToList();
        }
        
        //public void Refresh()
        //{
        //    IEnumerable<Service> filterService = DbConnect.db.Service.Where(x => x.isDelete != true).ToList();
        //    if (SortCb.SelectedIndex == 1)
        //        filterService = filterService.OrderBy(x => x.CostDiscount);
        //    else if (SortCb.SelectedIndex == 2)
        //        filterService = filterService.OrderByDescending(x => x.CostDiscount);
        //    if (DiscountSortCb.SelectedIndex > 0)
        //    {
        //        if (DiscountSortCb.SelectedIndex == 1)
        //            filterService = filterService.Where(x => x.Discount >= 0 && x.Discount < 0.05 || x.Discount == null).ToList();
        //        else if (DiscountSortCb.SelectedIndex == 2)
        //            filterService = filterService.Where(x => x.Discount >= 0.05 && x.Discount < 0.15).ToList();
        //        else if (DiscountSortCb.SelectedIndex == 3)
        //            filterService = filterService.Where(x => x.Discount >= 0.15 && x.Discount < 0.30).ToList();
        //        else if (DiscountSortCb.SelectedIndex == 4)
        //            filterService = filterService.Where(x => x.Discount >= 0.30 && x.Discount < 0.70).ToList();
        //        else if (DiscountSortCb.SelectedIndex == 5)
        //            filterService = filterService.Where(x => x.Discount >= 0.70 && x.Discount < 1).ToList();
        //    }
        //    if (TitleDescriptionTb.Text.Length > 0)
        //    {
        //        filterService = filterService.Where(x => x.Title.ToLower().StartsWith(TitleDescriptionTb.Text.ToLower()) || x.Description.ToLower().StartsWith(TitleDescriptionTb.Text.ToLower()));
        //    }
        //    ServiceList.ItemsSource = filterService.ToList();
        //    FilterCount.Text = filterService.Count() + " из";
        //}

        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Refresh();
        }

        private void DiscountSortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Refresh();
        }

        private void TitleDescriptionTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Refresh();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new Nav("Добавление услуги", new AddService(new Service())));
        }

        private void RedBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
