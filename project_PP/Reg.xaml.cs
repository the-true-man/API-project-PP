using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
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
    public partial class Reg : Page
    {
        Welcome_window welcome_window;
        List<object> allField;

        public Reg(Welcome_window welcome_window)
        {
            InitializeComponent();
            allField = new List<object>() {tb_lastname, tb_name, tb_midname};
            this.welcome_window = welcome_window;
            welcome_window.Title = this.Title;
        }
        delegate bool ValidateActions();
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            welcome_window.switch_page(this, this.welcome_window);
        }
        public bool validate_field_FIO()
        {
            foreach (TextBox field in allField)
            {
                if (!Regex.IsMatch(field.Text, @"^[а-яА-Я]+$|^[a-zA-Z]+$")) 
                {
                    MessageBox.Show("Некорректно заполнено поле");
                    field.Focus();
                    return false;
                }
                
            }
            return true;
        }
        public bool validate_field_email()
        {
            if (!Regex.IsMatch(tb_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") || tb_email.Text.Contains(".."))
            {
                MessageBox.Show("Некорректный E-Mail");
                tb_email.Focus();
                return false;
            }
            foreach(Person person in welcome_window.allUsers)
            {
                if(tb_email.Text.ToLower() == person.email)
                {
                    MessageBox.Show("E-Mail занят, попробуйте войти!");
                    tb_email.Focus();
                    return false;
                }
            }
            
            return true;
        }
        public bool validate_field_password()
        {
            if (!Regex.IsMatch(tb_password.Password, @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{6,15}$"))
            {
                MessageBox.Show("Пароль должен быть не менее 6 символов и не более 15, и обязательно английские буквы и хотя бы одну цифру!", "Не корректный пароль");
                tb_password.Focus();
                return false;
            }
            return true;
        }
        private async void btn_entry_Click(object sender, RoutedEventArgs e)
        {

            Person newPerson = new Person(tb_name.Text, tb_lastname.Text, tb_midname.Text, tb_email.Text, tb_password.Password);
            HttpClient client = new HttpClient();
            string url = "https://localhost:7272/api/User/Registration";
            var json = JsonConvert.SerializeObject(newPerson);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Вы успешно зарегистрировались!");
                }
                else
                {
                    MessageBox.Show("Поля заполнены некорректно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cb_show_password_Unchecked(object sender, RoutedEventArgs e)
        {
            tb_password_show.Visibility = Visibility.Collapsed;

        }

        private void cb_show_password_Checked(object sender, RoutedEventArgs e)
        {
            tb_password_show.Visibility = Visibility.Visible;
            tb_password_show.Text = tb_password.Password;
        }

        private void tb_password_show_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            tb_password.Password = tb_password_show.Text;
        }
    }
}
