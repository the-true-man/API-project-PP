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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project_PP
{
    /// <summary>
    /// Interaction logic for basket_page.xaml
    /// </summary>
    public partial class basket_page : Page
    {
        window_shop wp;
        public basket_page(window_shop wp)
        {
            InitializeComponent();
            this.wp = wp;
            lb_basket.ItemsSource = wp.basket;
            refreshGeneralCostBasket(lb_basket.Items);
        }
        int generalCostAllProductInBasket = 0;
        private void deleteProductFromBasket_Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            var contextItem = (Product)btn.DataContext;
            foreach(Product p in wp.allProducts)
            {
                if(p.Id == contextItem.Id)
                {
                    p.Count++;
                }
            }
            wp.basket.Remove(contextItem);
            
            lb_basket.ItemsSource = wp.basket;
            lb_basket.Items.Refresh();
            refreshGeneralCostBasket(lb_basket.Items);
            Serialize();
        }
        public void refreshGeneralCostBasket(ItemCollection products)
        {
            generalCostAllProductInBasket = 0;
            foreach (Product p in products)
            {
                generalCostAllProductInBasket += p.Cost;
            }
            lb_general_cost.Content = generalCostAllProductInBasket.ToString() + " ₽";
        }
        public void Serialize()
        {
            if (!File.Exists(wp.path))
            {
                File.Create(wp.path);
            }
            string json = JsonConvert.SerializeObject(wp.allProducts, Formatting.Indented);
            File.WriteAllText(wp.path, json);
        }
        private void deleteProductFromBasket(Product product)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            buyProductsInBasket();
        }
        private void buyProductsInBasket()
        {
            if (wp.basket.Count == 0)
            {
                MessageBox.Show("Корзина пустая");
                return;
            }
            MessageBox.Show("Заказ успешно оформлен!");
            Order newOrder = new Order(wp.basket.Count, generalCostAllProductInBasket, $"{DateTime.Now.ToString("G")}", wp.currentUser.Id);
            newOrder.Id = wp.currentUser.orders.Count+1;
            wp.basket.Clear();
            lb_basket.Items.Refresh();
            refreshGeneralCostBasket(lb_basket.Items);
            wp.currentUser.orders.Add(newOrder);
            wp.allUsers = wp.deserializeFile(wp.path2);
            foreach (Person cp in wp.allUsers)
            {
                if(cp.Id == wp.currentUser.Id)
                {
                    wp.allUsers[wp.allUsers.IndexOf(cp)] = wp.currentUser;
                   
                    break;
                }
            }
            wp.serializeFile(wp.path2);
        }
    }
}
