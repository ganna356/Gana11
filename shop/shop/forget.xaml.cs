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
    /// Interaction logic for forget.xaml
    /// </summary>
    public partial class forget : Page
    {
        shopEntities sho = new shopEntities();
        public forget()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin_ admin_=new Admin_();
            var forgeet = sho.Admin_.FirstOrDefault(x => x.Admin_name == name_f.Text);
            int pas=int.Parse(pass_f.Text);
            int pass=int.Parse(_new.Text);
            if(combo1.SelectedIndex == 0)
            {
                if(forgeet != null)
                {
                    if(forgeet.C_password==pas && pass==pas)
                    {
                        forgeet.C_password = pas;
                        sho.Admin_.AddOrUpdate(forgeet);
                        sho.SaveChanges();
                        MessageBox.Show("اشطر كتكوت");

                    }
                }
            }
            User_ user_ = new User_();
            var forgget=sho.User_.FirstOrDefault(x => x.user_name_==name_f.Text);
            int paas = int.Parse(pass_f.Text);
            int ppas=int.Parse(_new.Text);
            if(combo1.SelectedIndex==1)
            {
                if (forgget != null)
                {
                    if (forgget.password_ == paas && ppas == paas)
                    {
                        forgget.password_ = paas;
                        sho.User_.AddOrUpdate(forgget);
                        sho.SaveChanges();
                        MessageBox.Show("اشطر كتكوت");

                    }
                }
            }
        }
    }
}
