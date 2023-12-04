using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for update.xaml
    /// </summary>
    public partial class update : Page
    {
        shopEntities up = new shopEntities();
        public update()
        {
            InitializeComponent();
            d_u.ItemsSource=up.products.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            product product = new product();
            int Cod = int.Parse(co.Text);
            int pri=int.Parse(pr.Text);
            var Update=up.products.FirstOrDefault(x=>x.code == Cod);
            product.price = pri;
            product.type_ = na.Text;
            up.products.AddOrUpdate(product);
            up.SaveChanges();
            d_u.ItemsSource = up.products.ToList();
            MessageBox.Show("Updated Data");

        }
    }
}
