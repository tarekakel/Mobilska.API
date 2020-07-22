using System;
using System.Collections.Generic;

namespace Mobilska.API.Models
{
    public class ItemsModel
    {

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ReleaseYear { get; set; }
        public string MainImageUrl { get; set; }


        public BrandsModel Brand { get; set; }
        public CategoriesModel Category { get; set; }
        public ProductsModel Product { get; set; }
        public ProductTypeModel ProductType { get; set; }

    }
}
