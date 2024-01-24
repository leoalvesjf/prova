namespace ProvaPub.Models
{
	public class CustomerList : EntityList<Customer>
	{
		public List<Customer> Customers { get; set; }
		
	}
}
