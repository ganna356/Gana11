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
    /// Interaction logic for ADD.xaml
    /// </summary>
    public partial class ADD : Page
    {shopEntities shopEntities=new shopEntities();
        public ADD()
        {
            InitializeComponent();
            d_a.ItemsSource= shopEntities.products.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            product pro=new product();
            int Code = int.Parse(code.Text);
            int Price=int.Parse(price.Text);
            pro.code=Code;
            pro.price=Price;
            pro.type_ = name.Text;
            shopEntities.products.Add(pro);
            shopEntities.SaveChanges();
            d_a.ItemsSource = shopEntities.products.ToList();
            MessageBox.Show("Added new Data");

        }
    }
}
