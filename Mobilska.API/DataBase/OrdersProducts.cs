using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class OrdersProducts
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
