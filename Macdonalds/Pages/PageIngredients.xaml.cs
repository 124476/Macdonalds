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

namespace Macdonalds.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageIngredients.xaml
    /// </summary>
    public partial class PageIngredients : Page
    {
        public PageIngredients()
        {
            InitializeComponent();
            var ingredients = App.DB.DishAndElement.Where(x => x.DishId == App.Dish.Id).ToList();
            ListIngredients.ItemsSource = ingredients;
            DishName.Text = App.Dish.Name;
        }

        private void DownBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            App.dishes.Add(App.Dish);
            NavigationService.GoBack();
        }
    }
}
