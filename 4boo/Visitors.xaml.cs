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

namespace _4boo
{
    /// <summary>
    /// Логика взаимодействия для Visitors.xaml
    /// </summary>
    public partial class Visitors : Page
    {
        VISITORTableAdapter vis = new VISITORTableAdapter();
        public Visitors()
        {
            InitializeComponent();
            ColourDataGrid.ItemsSource = vis.GetData();

        }
    }
}