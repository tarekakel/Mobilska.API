using System;
using System.Collections.Generic;

namespace Mobilska.API.Models
{
	public class ProductsModel
	{
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



		public ItemsModel item { get; set; }
		public ProductTypeModel ProductType { get; set; }
		public BrandsModel Brand { get; set; }
		public CategoriesModel Category { get; set; }
		public List<string> ProductImages { get; set; }



	}
}
