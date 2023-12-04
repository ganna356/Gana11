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

namespace shop
{
    /// <summary>
    /// Interaction logic for delete.xaml
    /// </summary>
    public partial class delete : Page
    {
        shopEntities shopp = new shopEntities();
        public delete()
        {
            InitializeComponent();
            d.ItemsSource=shopp.products.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            product product = new product();
            int dele = int.Parse(delete1.Text);
            var del = shopp.products.FirstOrDefault(x => x.code == dele);
            if (del != null)
            {
                product.code = dele;
                shopp.products.Remove(del);
                shopp.SaveChanges();
                d.ItemsSource = shopp.products.ToList();
                MessageBox.Show("Deleted data");
            }
        }
    }
}
