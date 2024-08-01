using Macdonalds.Models;
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
using System.Windows.Threading;

namespace Macdonalds.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        DispatcherTimer dispatcherTimer;
        public PageMain()
        {
            InitializeComponent();
            Refresh();
            App.dishes = new List<Dish>();
            ListCategoryes.dishesDisplay = ListDishes;
        }

        private void SetDish(object sender, EventArgs e)
        {
            if (!App.IsDish)
                return;
            try
            {
                NavigationService.Navigate(new PageIngredients());
            }
            catch { }
            dispatcherTimer.Stop();
        }

        private void Refresh()
        {
            ListSaves.ItemsSource = null;
            ListSaves.ItemsSource = App.dishes;
            if (App.dishes.Count > 0)
            {
                TextNull.Visibility = Visibility.Collapsed;
                ListSaves.Visibility = Visibility.Visible;
                SaveBtn.IsEnabled = true;
            }
            else
            {
                TextNull.Visibility = Visibility.Visible;
                ListSaves.Visibility = Visibility.Collapsed;
                SaveBtn.IsEnabled = false;
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Точно отменить?", "Сообщение", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                return;
            App.IsBack = true;
            for (int i = 0; i < 2; i ++)
                NavigationService.GoBack();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageOplata());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.IsBack = false;
            App.IsDish = false;
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(250);
            dispatcherTimer.Tick += SetDish;
            dispatcherTimer.Start();

            Refresh();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            App.IsBack = true;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var dish = (sender as Hyperlink).DataContext as Dish;

            if (dish == null)
                return;

            if (MessageBox.Show("Вы точно хотите удалить?", "Сообщение", MessageBoxButton.YesNoCancel) != MessageBoxResult.Yes)
                return;

            App.dishes.Remove(dish);
            Refresh();
        }
    }
}
