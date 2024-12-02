using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace project_PP
{
    /// <summary>
    /// Interaction logic for profile_page.xaml
    /// </summary>
    public partial class profile_page : Page
    {
        window_shop ws;
        public profile_page(window_shop ws)
        {
            InitializeComponent();
            this.ws = ws;
            updateField();

        }
        public void updateField()
        {
            tb_surename.Text = ws.currentUser.lastName;
            tb_name.Text = ws.currentUser.Name;
            tb_midname.Text = ws.currentUser.middleName;
            lb_email.Text = ws.currentUser.email;
            lv_orders.ItemsSource = ws.currentUser.orders;
        }

        
        private void refreshUser()
        {
            ws.allUsers = ws.deserializeFile(ws.path2);
            foreach (Person p in ws.allUsers)
            {
                if (p.Id == ws.currentUser.Id)
                {
                    ws.allUsers[ws.allUsers.IndexOf(p)] = ws.currentUser;
                    ws.serializeFile(ws.path2);
                    break;
                }
            }
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(tb_surename.Text, @"^[а-яА-Я]+$|^[a-zA-Z]+$"))
            {
                tb_surename.Focus();
                MessageBox.Show("Некорректно заполнено поле");
                return;
            }
            if (!Regex.IsMatch(tb_name.Text, @"^[а-яА-Я]+$|^[a-zA-Z]+$"))
            {
                tb_name.Focus();
                MessageBox.Show("Некорректно заполнено поле");
                return;
            }
            if (!Regex.IsMatch(tb_midname.Text, @"^[а-яА-Я]+$|^[a-zA-Z]+$"))
            {
                tb_midname.Focus();
                MessageBox.Show("Некорректно заполнено поле");
                return;
            }
            if (!Regex.IsMatch(lb_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                lb_email.Focus();
                MessageBox.Show("Некорректно заполнено поле");
                return;
            }
            foreach (var item in ws.allUsers)
            {

                if (item.email == lb_email.Text && item.Id != ws.currentUser.Id)
                {
                    MessageBox.Show("Почта занята");
                    return;
                }

            }
            ws.currentUser.email = lb_email.Text;
            ws.currentUser.Name = tb_name.Text;
            ws.currentUser.lastName = tb_surename.Text;
            ws.currentUser.middleName = tb_midname.Text;
            refreshUser();
        }
    }
}
