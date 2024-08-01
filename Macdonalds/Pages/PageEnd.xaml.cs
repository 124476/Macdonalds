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

namespace Macdonalds.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEnd.xaml
    /// </summary>
    public partial class PageEnd : Page
    {
        public PageEnd()
        {
            InitializeComponent();
            App.IsBack = false;
            var zakaz = new Zakaz();
            zakaz.IsPreparing = true;
            zakaz.IsHere = App.IsHere;
            var num = App.DB.Zakaz.ToList().LastOrDefault().Id.ToString();
            if (num.Length == 1)
                num = "0" + num;
            zakaz.Number = num;
            App.DB.Zakaz.Add(zakaz);
            foreach(var dish in App.dishes)
            {
                var zakazAndDish = new ZakazAndDish();
                zakazAndDish.Zakaz = zakaz;
                zakazAndDish.Dish = dish;
                App.DB.ZakazAndDish.Add(zakazAndDish);
            }
            App.DB.SaveChanges();
            NumberText.Text = num;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            App.IsBack = true;
            for (int i = 0; i < 4; i++)
                NavigationService.GoBack();
        }
    }
}
