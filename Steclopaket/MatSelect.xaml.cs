using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Steclopaket
{
    /// <summary>
    /// Interaction logic for MatSelect.xaml
    /// </summary>
    public partial class MatSelect : Window
    {
        public PaketDataContext DbContext;

        public MatSelect()
        {
            InitializeComponent();
            var connStr = ConfigurationManager.ConnectionStrings["connstr"].ToString();
            DbContext = new PaketDataContext(connStr);
        }

        private void MaterChoice_Loaded(object sender, RoutedEventArgs e)
        {
            lbMaterSelect.ItemsSource = from m in DbContext.Materials
                                        select m.Name;
        }
       
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void tbnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void tbQty_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9,]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
