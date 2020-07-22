using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
