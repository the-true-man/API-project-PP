using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace project_PP
{
    /// <summary>
    /// Interaction logic for window_shop.xaml
    /// </summary>
    public partial class window_shop : Window
    {
        public List<Product> basket = new List<Product>();
        public List<Person> allUsers = new List<Person>();
        public List<Product> allProducts = new List<Product>();
        public string path = "products_in_shop.json";
        public string path2 = "allUsers.json";

        public Person currentUser;
        bool closeWindow = false;
        public window_shop(Person currentUser)
        {
            InitializeComponent();
           this.currentUser = currentUser;
            open_shop();
        }
        private void open_basket()
        {
            if (currentUser.isGuest) {
                MessageBox.Show("Вы гость!");
                return;
            }
            frame_shop.Content = new basket_page(this);

        }
        private void open_shop()
        {
            frame_shop.Content = new page_shop(this);

        }
        private void open_profile()
        {
            if (currentUser.isGuest)
            {
                MessageBox.Show("Вы гость!");
                return;
            }
            frame_shop.Content = new profile_page(this);

        }

        private void btn_shop_Click(object sender, RoutedEventArgs e)
        {
            open_shop();

        }

        private void btn_basket_Click(object sender, RoutedEventArgs e)
        {
            open_basket();

        }

        private void Window_Closed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!closeWindow) 
            {
                closeWindow = closeWindowConfirm();
            }
            
            if (closeWindow == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private bool closeWindowConfirm()
        {
            if (basket.Count == 0)
            {
                return true;
            }
            if (MessageBox.Show("Корзина не будет сохранена! Продолжить?", "Закрыть?", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                return false;
            }
            return true;
        }
        private void btn_profile_Click(object sender, RoutedEventArgs e)
        {
            open_profile();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            exitToLogin();
        }
        public void exitToLogin()
        {
            closeWindow = closeWindowConfirm();
            if (closeWindow == false) 
            { 
                return;
            }
            Welcome_window welcome_Window = new Welcome_window();
            welcome_Window.Show();
            this.Close();

        }
        public List<Person> deserializeFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Person>>(json);
        }
        public void serializeFile(string path)
        {
            string json = JsonConvert.SerializeObject(allUsers);
            File.WriteAllText(path, json);
        }
    }
}
