using System;
using System.Collections.Generic;

namespace Mobilska.API.Models
{
    public class ProductImagesModel
    {
        public int ProductId { get; set; }
        public string ImageSource { get; set; }

        public ProductsModel Product { get; set; }
    }
}
