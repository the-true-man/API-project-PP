using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace project_PP
{
    public class Order
    {
        public int Id { get; set; }
        public int IdUser { get; set; }

        public int Count_item { get; set; }
        public int General_cost { get; set; }
        public string DateOrder { get; set; }

        public string Status { get; set; } = "Оформлен";

        public Order( int count_item, int general_cost, string dateOrder, int idUser)
        {
            Count_item = count_item;
            General_cost = general_cost;
            DateOrder = dateOrder;
            IdUser = idUser;
        }
    }
}
