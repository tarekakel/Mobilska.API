using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mobilska.API.DataBase;
using Mobilska.API.Models;

namespace Mobilska.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{

		// Get Trending products
		// http://localhost:5432/api/Products/GetProductsIsTrending/true

		[HttpGet("GetProductsIsTrending/{IsTrending}")]
		public IActionResult GetProductsIsTrending(bool IsTrending)
		{
			var db = new MobilskaDbContext();
			//List<ProductsModel> MobilskaProducts = db.Products.Where(p => p.IsTrending == IsTrending)
			//	.Select(dbItem => new ProductsModel()
			//	{
			//		IsTrending = dbItem.IsTrending,
			//		Id = dbItem.Id,
			//		Name = dbItem.Name,
			//		Description = dbItem.Description,
			//		ProductTypeId = dbItem.ProductTypeId,
			//		OnSale = dbItem.OnSale,
			//		ProductType = new ProductTypeModel() { Type = dbItem.ProductType.Type },
			//		Brand = new BrandsModel() { Name = dbItem.Item.Brand.Name, IconName = dbItem.Item.Brand.IconName },
			//		Category = new CategoriesModel() { Name = dbItem.Item.Category.Name },
			//		ProductImages = dbItem.ProductImages.Where(e => e.ProductId == dbItem.Id).Select(e => e.ImageSource).ToList(),

			//	}).ToList();

			

			db.Dispose();
			return Ok(db.Products.Where(p => p.IsTrending == IsTrending).ToList());
		}


		// Get Brands ProductTypeID 
		// http://localhost:5432/api/Products/GetBrandsByProductTypeID/1

		[HttpGet("GetBrandsByProductTypeID/{id}")]
		public IActionResult GetBrandsByProductTypeID(int id)
		{
			var db = new MobilskaDbContext();

			List<BrandsModel> MobilskaBrands = db.Brands.Where(p => p.Items.Any(e => e.Products.Any(x => x.ProductTypeId == id)))
				.Select(dbItem => new BrandsModel()
				{
					Id = dbItem.Id,
					Name = dbItem.Name,
					IconName = dbItem.IconName,
					MainImageUrl = dbItem.MainImageUrl,

				}).ToList();

			db.Dispose();
			return Ok(MobilskaBrands);
		}


		// Get Items by ProductTypeID 
		// http://localhost:5432/api/Products/GetItemsByProductTypeId/1

		[HttpGet("GetItemsByProductTypeId/{ProductTypeId}")]
		public IActionResult GetItemsByProductTypeId(int ProductTypeId)
		{
			var db = new MobilskaDbContext();

			List<ItemsModel> MobilskaItems = db.Items.Where(p => p.Products.Any(e => e.ProductTypeId == ProductTypeId))
				.Select(dbItem => new ItemsModel()
				{
					Id = dbItem.Id,
					Name = dbItem.Name,
					ReleaseYear = dbItem.ReleaseYear,
					MainImageUrl = dbItem.MainImageUrl,

				}).ToList();

			db.Dispose();
			return Ok(MobilskaItems);
		}


		// Get Items by ProductTypeID and BrandID 
		// http://localhost:5432/api/Products/GetItemsByProductTypeIdandBrandsID/1/1

		[HttpGet("GetItemsByProductTypeIdandBrandsID/{ProductTypeId}/{BrandId}")]
		public IActionResult GetItemsByProductTypeIdandBrandsID(int ProductTypeId, int BrandId)
		{
			var db = new MobilskaDbContext();

			List<ItemsModel> MobilskaItems = db.Items.Where(p => p.Products.Any(e => e.ProductTypeId == ProductTypeId && e.Item.BrandId == BrandId))
				.Select(dbItem => new ItemsModel()
				{
					Id = dbItem.Id,
					Name = dbItem.Name,
					ReleaseYear = dbItem.ReleaseYear,
					MainImageUrl = dbItem.MainImageUrl,

				}).ToList();

			db.Dispose();
			return Ok(MobilskaItems);
		}


		// Get Item by ProductTypeID and ItemID 
		// http://localhost:5432/api/Products/GetItemsByItemID/1

		[HttpGet("GetItemsByItemID/{ItemId}")]
		public IActionResult GetItemsByItemID(int ItemId)
		{
			var db = new MobilskaDbContext();

			List<ItemsModel> MobilskaItem = db.Items.Where(p => p.Id == ItemId)
				.Select(dbItem => new ItemsModel()
				{
					Id = dbItem.Id,
					Name = dbItem.Name,
					ReleaseYear = dbItem.ReleaseYear,
					MainImageUrl = dbItem.MainImageUrl,

				}).ToList();

			db.Dispose();
			return Ok(MobilskaItem);
		}


		// Get Products by ProductTypeID 
		// http://localhost:5432/api/Products/GetProductsByProductTypeId/1

		[HttpGet("GetProductsByProductTypeId/{ProductTypeId}")]
		public IActionResult GetProductsByProductTypeId(int ProductTypeId)
		{
			var db = new MobilskaDbContext();

			List<ProductsModel> MobilskaProducts = db.Products.Where(p => p.ProductTypeId == ProductTypeId)
				.Select(dbItem => new ProductsModel()
				{
					Id = dbItem.Id,
					Name = dbItem.Name,
					Description = dbItem.Description,
					PriceKr = dbItem.PriceKr,
					PriceUsd = dbItem.PriceUsd,
					OnSale = dbItem.OnSale,

					item = new ItemsModel() { Name = dbItem.Item.Name },
					ProductImages = dbItem.ProductImages.Where(e => e.ProductId == dbItem.Id).Select(e => e.ImageSource).ToList(),

				}).ToList();

			db.Dispose();
			return Ok(MobilskaProducts);
		}

		// Get Product by ProductID 
		// http://localhost:5432/api/Products/GetProductByProductId/1

		[HttpGet("GetProductByProductId/{ProductId}")]
		public IActionResult GetProductByProductId(int ProductId)
		{
			var db = new MobilskaDbContext();

			List<ProductsModel> MobilskaProducts = db.Products.Where(p => p.Id == ProductId)
				.Select(dbItem => new ProductsModel()
				{
					Id = dbItem.Id,
					Name = dbItem.Name,
					Description = dbItem.Description,
					PriceKr = dbItem.PriceKr,
					PriceUsd = dbItem.PriceUsd,
					OnSale = dbItem.OnSale,
					YoutubeUrl = dbItem.YoutubeUrl,

					item = new ItemsModel() { Name = dbItem.Item.Name },
					Brand = new BrandsModel() { Name = dbItem.Item.Brand.Name},
					ProductImages = dbItem.ProductImages.Where(e => e.ProductId == dbItem.Id).Select(e => e.ImageSource).ToList(),

				}).ToList();

			db.Dispose();
			return Ok(MobilskaProducts);
		}


		// Get Products by ProductTypeID and ItemID 
		// http://localhost:5432/api/Products/GetProductsByProductTypeIdandItemID/1/1

		[HttpGet("GetProductsByProductTypeIdandItemID/{ProductTypeId}/{ItemId}")]
		public IActionResult GetProductsByProductTypeIdandItemID(int ProductTypeId, int ItemId)
		{
			var db = new MobilskaDbContext();

			List<ProductsModel> MobilskaProducts = db.Products.Where(p => p.ProductTypeId == ProductTypeId && p.ItemId == ItemId)
				.Select(dbItem => new ProductsModel()
				{
					Id = dbItem.Id,
					Name = dbItem.Name,
					Description = dbItem.Description,
					PriceKr = dbItem.PriceKr,
					PriceUsd = dbItem.PriceUsd,
					OnSale = dbItem.OnSale,

					item = new ItemsModel() { Name = db.Items.FirstOrDefault(e => e.Id == ItemId).Name },
					ProductImages = dbItem.ProductImages.Where(e => e.ProductId == dbItem.Id).Select(e => e.ImageSource).ToList(),

				}).ToList();

			db.Dispose();
			return Ok(MobilskaProducts);
		}

	}
}