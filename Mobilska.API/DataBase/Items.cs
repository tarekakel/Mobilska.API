using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class Items
    {
        public Items()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ReleaseYear { get; set; }
        public string MainImageUrl { get; set; }

        public virtual Brands Brand { get; set; }
        public virtual Categories Category { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
