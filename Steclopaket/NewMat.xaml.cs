using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common.CommandTrees;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class NewMat : Window
    {
        public PaketDataContext DbContext;

        public NewMat()
        {
            InitializeComponent();
            var connStr = ConfigurationManager.ConnectionStrings["connstr"].ToString();
            DbContext = new PaketDataContext(connStr);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                MessageBox.Show("Enter name!");
                return;
            }
            var material = new Material
            {
                Id = Guid.NewGuid(),
                Name = tbName.Text
            };
            DbContext.Materials.InsertOnSubmit(material);
            DbContext.SubmitChanges();
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
