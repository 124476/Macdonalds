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
    /// Логика взаимодействия для PageOplata.xaml
    /// </summary>
    public partial class PageOplata : Page
    {
        public PageOplata()
        {
            InitializeComponent();
        }

        private void OplataBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageEnd());
        }
    }
}
