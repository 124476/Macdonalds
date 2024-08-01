using Macdonalds.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Macdonalds
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MacdonaldsDatabaseEntities DB = new MacdonaldsDatabaseEntities();
        public static bool IsHere;
        public static List<Dish> dishes = new List<Dish>();
        public static Category Category = App.DB.Category.ToList()[0];
        public static Dish Dish;
        public static bool IsDish = false;
        public static bool IsBack = true;
        public App()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Error");
        }
    }
}
