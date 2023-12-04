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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        public admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            update update  =new update();
            this.NavigationService.Navigate(update);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            delete delete = new delete();
            this.NavigationService.Navigate(delete);    
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ADD aDD = new ADD();
            this.NavigationService.Navigate(aDD);
        }
    }
}
