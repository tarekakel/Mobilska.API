using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public float TotalPriceUsd { get; set; }
        public float TotalPriceKr { get; set; }
        public int OrderStatusId { get; set; }

        public virtual Clients Client { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
    }
}
