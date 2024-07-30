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

namespace Macdonalds.Controls
{
    /// <summary>
    /// Логика взаимодействия для WorkedZakaz.xaml
    /// </summary>
    public partial class WorkedZakaz : UserControl
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public WorkedZakaz()
        {
            InitializeComponent();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(3);
            dispatcherTimer.Tick += SetRefresh;
            dispatcherTimer.Start();
            Refresh();
        }

        public void Refresh()
        {
            ListNo.ItemsSource = App.DB.Zakaz.Where(x => x.IsPreparing == true).ToList();
            ListOk.ItemsSource = App.DB.Zakaz.Where(x => x.IsPreparing == false).ToList();
        }

        private void SetRefresh(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
