using _4boo.EL_PATIODataSetTableAdapters;
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
using System.Data;

namespace _4boo
{

    public partial class ItalianoMenu : Page
    {
        ITALIAN_MENU_PATIOTableAdapter italia = new ITALIAN_MENU_PATIOTableAdapter();
       
        public ItalianoMenu()
        {
            InitializeComponent();
            ColourDataGrid.ItemsSource = italia.GetData();
            Menu.DisplayMemberPath = "ITALIAN_FOOD_PATIO_PRICE";
            Menu.ItemsSource = italia.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ColourDataGrid.ItemsSource = italia.SearchByName(SearchTxt.Text);
        }

        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {
            if (Menu.SelectedItem !=null ) 
            {
                var id = (string)(Menu.SelectedItem as DataRowView).Row[2];
                ColourDataGrid.ItemsSource = italia.FilterByName(id);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            Menu.SelectedItem = null;
            SearchTxt.Text = string.Empty;
            ColourDataGrid.ItemsSource = italia.GetData();
        }
    }
}
