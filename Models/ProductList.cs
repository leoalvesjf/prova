namespace ProvaPub.Models
{
	public class ProductList : EntityList<Product>
	{
		public List<Product> Products { get; set; }
		
	}
}
