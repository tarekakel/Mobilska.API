using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
