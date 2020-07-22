using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class ProductImages
    {
        public int ProductId { get; set; }
        public string ImageSource { get; set; }

        public virtual Products Product { get; set; }
    }
}
