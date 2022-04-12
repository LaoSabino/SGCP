using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCP.Core
{
    public class Order
    {
        public Order()
        {
            Items = new List<ItemOrder>();
        }
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }

        public Promotion Promotion { get; set; }

        public Client Client { get; set; }
        
        public List<ItemOrder> Items { get; set; }

        public decimal Total { get; set; }
    }
}
