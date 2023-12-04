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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        shopEntities Shop = new shopEntities();
        public signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin_ admin_ =new Admin_ ();
           
            if(comb.SelectedIndex == 0) 
            {
                admin_.Admin_name = n_s.Text;
                admin_.email = e_s.Text;
                int pas=int.Parse(p_s.Text);
                admin_.C_password = pas;
                Shop.Admin_.Add(admin_);
                Shop.SaveChanges();
                MessageBox.Show("اهلا بالكتكوت الجديد");
                
            }
            User_ user_ = new User_();

            if(comb.SelectedIndex == 1)
            {
                user_.user_name_= n_s.Text;
                user_.email = e_s.Text;
                int pass=int.Parse(p_s.Text);   
                user_.password_= pass;
                Shop.User_.Add(user_);
                Shop.SaveChanges();
                MessageBox.Show("اهلا بالكتكوت الجديد");
            }
        }
    }
}
