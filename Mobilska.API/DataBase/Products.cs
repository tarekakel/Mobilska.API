using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class Products
    {
        public Products()
        {
            ProductImages = new HashSet<ProductImages>();
        }

        public int Id { get; set; }
        public int ItemId { get; set; }
        public float? PriceUsd { get; set; }
        public float? PriceKr { get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? OnSale { get; set; }
        public bool? IsTrending { get; set; }
        public string YoutubeUrl { get; set; }

        public virtual Items Item { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }
    }
}
