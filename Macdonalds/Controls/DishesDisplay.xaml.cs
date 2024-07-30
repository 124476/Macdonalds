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
    /// Логика взаимодействия для DishesDisplay.xaml
    /// </summary>
    public partial class DishesDisplay : UserControl
    {
        public DishesDisplay()
        {
            InitializeComponent();
            Refresh();
        }

        public void Refresh()
        {
            ListDishes.ItemsSource = App.DB.Dish.Where(x => x.CategoryId == App.Category.Id).ToList();
        }
    }
}
