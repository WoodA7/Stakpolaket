using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Steclopaket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public PaketDataContext DbContext;

        public MainWindow()
        {
            InitializeComponent();
            var connStr = ConfigurationManager.ConnectionStrings["connstr"].ToString();
            DbContext = new PaketDataContext(connStr);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var result = from c in DbContext.Orders
                select new
                {
                    c.Date,
                    c.Customer1.Name,
                    c.Products
                };
            dgOrders.ItemsSource = result;

        }

        private void btnNewMat_Click(object sender, RoutedEventArgs e)
        {
            var wnd = new NewMat { Owner = this };
            wnd.Show();
        }

        private void TabItem_MouseEnter(object sender, MouseEventArgs e)
        {
            var result = from m in DbContext.Materials
                select new
                {
                    m.Name
                };
            dgOrders.ItemsSource = result;
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            var wnd = new NewOrder { Owner = this };
            wnd.Show();
        }

        private void btnNewProd_Click(object sender, RoutedEventArgs e)
        {
            var wnd = new NewProduct {Owner = this};
            wnd.Show();
        }
    }

}
