using ProvaPub.Models;
using ProvaPub.Repository;
using PagedList;


namespace ProvaPub.Services
{
	public class ProductService
	{
        private readonly TestDbContext _ctx;

        public ProductService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public ProductList ListProducts(int page,int pageSize)
        {                    

            var product = _ctx.Products.ToPagedList(page, pageSize);
            
            return new ProductList() { HasNext = true, TotalCount = pageSize, Products = product.ToList() };

        }

    }
}
