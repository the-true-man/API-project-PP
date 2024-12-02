using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_PP
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public string Describtion { get; set; }
        private static int _uniqID = 1;
        public Product(string title, int count, int cost, string desctiption)
        {
            Id = _uniqID;
            _uniqID++;
            Title = title;
            Count = count;
            if (count < 0)
            {
                Count = 0;
            }
            Cost = cost;
            Describtion = desctiption;
        }
    }
}
