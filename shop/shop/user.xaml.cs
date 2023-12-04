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
    /// Interaction logic for user.xaml
    /// </summary>
    public partial class user : Page

    {
        shopEntities sho = new shopEntities();
        public user()
        {
            InitializeComponent();
            dg.ItemsSource = sho.products.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           product Product = new product();
            var pro =sho.products.FirstOrDefault(x =>x.type_.Contains(search.Text));
            if (pro != null)
            {
                dg.ItemsSource=sho.products.ToList();
            }
            else
            {
                MessageBox.Show("sorry not found");
            }
           
        }
    }
}
