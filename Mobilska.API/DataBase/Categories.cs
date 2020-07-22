using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class Categories
    {
        public Categories()
        {
            Items = new HashSet<Items>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Items> Items { get; set; }
    }
}
