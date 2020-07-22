using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class Store
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float? Cost { get; set; }
        public float? PriceBeforeTaxKr { get; set; }
        public float? PriceBeforeTaxUsd { get; set; }

        public virtual Products Product { get; set; }
    }
}
