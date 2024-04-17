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
using _4boo.EL_PATIODataSetTableAdapters;
namespace _4boo
{

    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            ItalianoMenu ItalianoMenuPage = new ItalianoMenu();
            this.Content = ItalianoMenuPage;
        }


     


        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Visitors VisitorsPage = new Visitors();
            this.Content = VisitorsPage;
        }


        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Waiter WaiterPage = new Waiter();
            this.Content = WaiterPage;
        }

    }
}