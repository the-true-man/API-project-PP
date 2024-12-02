using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace project_PP
{
    /// <summary>
    /// Interaction logic for Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        Welcome_window welcome_window;

        public Auth(Welcome_window welcome_window)
        {
            InitializeComponent();
            this.welcome_window = welcome_window;
            welcome_window.Title = this.Title;
        }
        
        private async void btn_entry_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            string urlAuth = "https://localhost:7272/api/User/Auth";
            string urlAllUsers = "https://localhost:7272/api/User/allUsers";

            var loginData = new
            {
                email = tb_email.Text.Trim(),
                password = tb_password.Password.Trim()
            };
            var data = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync(urlAuth, content);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Некорректный логин или пароль");
                    return;
                }

                HttpResponseMessage response2 = await client.GetAsync(urlAllUsers);
                if (response2.IsSuccessStatusCode)
                {
                    string json = await response2.Content.ReadAsStringAsync();
                    List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(json);
                    window_shop window = new window_shop(persons.FirstOrDefault(u => u.email == tb_email.Text));
                    window.Show();
                    welcome_window.Close();
                    MessageBox.Show("Вы успешно вошли!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }

        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            welcome_window.switch_page(this, this.welcome_window);
        }

        private void Hyperlink_Click_Auth_how_guest(object sender, RoutedEventArgs e)
        {
            Person guest = new Person("", "", "", "auth::guest", "");
            guest.Id = 0;
            guest.isGuest = true;
            window_shop window_Shop = new window_shop(guest);
            window_Shop.Show();
            welcome_window.Close();
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

        private void tb_password_show_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb_password.Password = tb_password_show.Text;
        }
    }
}
