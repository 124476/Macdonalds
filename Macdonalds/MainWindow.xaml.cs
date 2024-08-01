using Macdonalds.Pages;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Macdonalds
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.Navigate(new PageStart());

            //var categoryes = App.DB.Element.ToList();
            //var dialog = new OpenFileDialog() { Multiselect = true };
            //if (dialog.ShowDialog().GetValueOrDefault())
            //{
            //    var files = dialog.FileNames;
            //    for (int i = 0; i < files.Count(); i++)
            //    {
            //        categoryes[i].Photo = File.ReadAllBytes(files[i]);
            //    }
            //}
            //App.DB.SaveChanges();
        }

        private void MyFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MyFrame.CanGoBack && App.IsBack)
            {
                BackBtn.Visibility = Visibility.Visible;
                Reclama.Visibility = Visibility.Collapsed;
            }
            else
            {
                BackBtn.Visibility = Visibility.Collapsed;
                Reclama.Visibility = Visibility.Visible;
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.GoBack();
        }
    }
}
