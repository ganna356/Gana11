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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        shopEntities sh = new shopEntities();
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User_ u = new User_();
            var use = sh.User_.FirstOrDefault(x => x.user_name_ == u_l.Text);
           int pass=int.Parse(p_l.Text);
            if(comb.SelectedIndex== 1)
            {
                if (use != null && use.password_ == pass && use.email==e_l.Text)
                {
                    user us=new user();
                    this.NavigationService.Navigate(us);

                }
                else
                {
                    MessageBox.Show("Error in password or email or name please try again or click on forget password ");
                }

            }
            Admin_ admin_ = new Admin_();
            var Adm = sh.Admin_.FirstOrDefault(x => x.Admin_name == u_l.Text);
            int pas = int.Parse(p_l.Text);
            if (comb.SelectedIndex == 0)
            {
                if (Adm != null && Adm.C_password == pas && Adm.email == e_l.Text)
                {
                    admin admin = new admin();
                    this.NavigationService.Navigate(admin);

                }
                else
                {
                    MessageBox.Show("Error in password or email or name please try again or click on forget password ");
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            signup signup = new signup();
            this.NavigationService.Navigate(signup);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forget forgeet=new forget();    
            this.NavigationService.Navigate(forgeet);
        }
    }
}
