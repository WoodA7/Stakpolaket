using System;
using System.Data;
using System.Collections.Generic;
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
        public NewMat()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text.Length == 0)
            {
                MessageBox.Show("Enter name!");
                return;
            }
            PaketDataContext db = new PaketDataContext();
            Material material = new Material();
            material.Id = Guid.NewGuid();
            material.Name = tbName.Text;
            db.Materials.InsertOnSubmit(material);
            db.SubmitChanges();
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
