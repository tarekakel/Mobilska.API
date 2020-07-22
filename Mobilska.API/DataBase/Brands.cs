using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class Brands
    {
        public Brands()
        {
            Items = new HashSet<Items>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public string IconName { get; set; }
        public string MainImageUrl { get; set; }

        public virtual ICollection<Items> Items { get; set; }
    }
}
