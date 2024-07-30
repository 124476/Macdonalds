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

namespace Macdonalds.Controls
{
    /// <summary>
    /// Логика взаимодействия для CategoryesDisplay.xaml
    /// </summary>
    public partial class CategoryesDisplay : UserControl
    {
        public DishesDisplay dishesDisplay;
        public CategoryesDisplay()
        {
            InitializeComponent();

            foreach (var item in App.DB.Category.ToList())
                item.Color = "Black";
            App.DB.Category.ToList()[0].Color = "White";
            ListCategoryes.ItemsSource = App.DB.Category.ToList();
        }

        private void ListCategoryes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in App.DB.Category.ToList())
                item.Color = "Black";

            var category = ListCategoryes.SelectedItem as Category;
            category.Color = "White";

            App.Category = category;
            ListCategoryes.ItemsSource = App.DB.Category.ToList();
            dishesDisplay.Refresh();
        }
    }
}
