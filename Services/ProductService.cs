using ProvaPub.Models;
using ProvaPub.Repository;
using PagedList;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using PagedList.Mvc;

namespace ProvaPub.Services
{
	public class ProductService
	{
		TestDbContext _ctx;

		public ProductService(TestDbContext ctx)
		{
			_ctx = ctx;
		}

		public ProductList  ListProducts(int page)
		{
			int pageSize = 10;
			int pageNumber = (page);

			var product = _ctx.Products.ToPagedList(pageNumber, pageSize);

			return new ProductList() { HasNext = true, TotalCount = 10, Products = product.ToList() };
            
        }

	}
}
