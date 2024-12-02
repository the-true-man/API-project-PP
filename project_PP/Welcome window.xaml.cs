using Newtonsoft.Json;
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
using System.IO;

namespace project_PP
{
    public partial class Welcome_window : Window
    {
        public List<Person> allUsers;
        public string pathToFile = "allUsers1.json";
        public Welcome_window()
        {
            InitializeComponent();
            allUsers = deserializeFile(pathToFile) ?? new List<Person>();
            Auth auth = new Auth(this);
            frameWelcomeWindow.Content = auth;
            this.Title = auth.Title;
        }
        public void switch_page<T>(T page, Welcome_window welcome_Window)
        {
            if (typeof(T) != typeof(Auth))
            {
                welcome_Window.frameWelcomeWindow.Content = new Auth(this);
            }
            else
            {
                welcome_Window.frameWelcomeWindow.Content = new Reg(this);
            }
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
 