using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
    /// Interaction logic for page_shop.xaml
    /// </summary>
    public partial class page_shop : Page
    {
        List<Product> basket = new List<Product> { };
        window_shop ws;
        
        public page_shop(window_shop ws)
        {
            InitializeComponent();
            this.ws = ws;
            
            Deserialize();
            lv_items.ItemsSource = ws.allProducts;
        }
        public void Serialize()
        {
            if (!File.Exists(ws.path))
            {
                using (File.Create(ws.path)) { }
            }
            string json = JsonConvert.SerializeObject(ws.allProducts, Formatting.Indented);
            File.WriteAllText(ws.path, json);
        }
        public void Deserialize()
        {
            if (!File.Exists(ws.path))
            {
                using (File.Create(ws.path)) { }
                return;
            }
            string json = File.ReadAllText(ws.path);
            ws.allProducts = JsonConvert.DeserializeObject<List<Product>>(json);
        }
        private void AddBasket_Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var contextItem = (Product)btn.DataContext;
            addProductInBasket(contextItem);


        }
        private void addProductInBasket(Product product)
        {
            if (ws.currentUser.isGuest is true)
            {
                MessageBox.Show("Войдите чтобы добавлять товары в корзину!");
                return;
            }
            if(product.Count == 0)
            {
                MessageBox.Show("Товар закончился( -вайб");
                return;
            }
            if(ws.basket.Count >= 50)
            {
                MessageBox.Show("Наши покупатели - физические лица. Корзина переполнена!");
                return;
            }
            ws.basket.Add(product);
            product.Count--;
            lv_items.Items.Refresh();
            Serialize();
            
        }
    }
}
