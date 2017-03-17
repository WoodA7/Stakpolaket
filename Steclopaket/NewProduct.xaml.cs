using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace Steclopaket
{
    /// <summary>
    /// Interaction logic for NewProduct.xaml
    /// </summary>
    public partial class NewProduct : Window
    {
        public PaketDataContext DbContext;

        public NewProduct()
        {
            InitializeComponent();
            var connStr = ConfigurationManager.ConnectionStrings["connstr"].ToString();
            DbContext = new PaketDataContext(connStr);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (tbProdName.Text.Length <= 0)
            {
                MessageBox.Show("Enter name first!");
                return;
            }
            var res = from p in DbContext.Products
                      where p.Name == tbProdName.Text
                      select p.Name;

            if (res.Any()) return;

            var mc = new MatSelect();
            if (mc.ShowDialog() == false) return;

            var sel_name = mc.lbMaterSelect.SelectedValue.ToString();
            double mat_qty;
            if (!double.TryParse(mc.tbQty.Text, out mat_qty))
                return;
            mc.Close();

            var mat = (from m in DbContext.Materials
                       where m.Name == sel_name
                       select m.Id).First();

            var productMult = new ProductMult
            {
                Id = Guid.NewGuid(),
                Mater_Id = mat,
                Mater_Qty = mat_qty
            };
            DbContext.ProductMults.InsertOnSubmit(productMult);
            DbContext.SubmitChanges();

            UpdDataGrid();

        }

        private void UpdDataGrid()
        {
            dgMaterInProduct.ItemsSource = from pm in DbContext.ProductMults
                                           join p in DbContext.Products on pm.Mater_Id equals p.Id
                                           select new
                                           {
                                               pm.Material.Name,
                                               Quantity = pm.Mater_Qty
                                           };
        }

        private void dgMaterInProduct_Loaded(object sender, RoutedEventArgs e)
        {
            UpdDataGrid();
        }

        private void btnSaveProd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
