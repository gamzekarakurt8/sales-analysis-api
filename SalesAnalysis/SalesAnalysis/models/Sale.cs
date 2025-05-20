namespace SalesAnalysis.models
{
	public class Sale
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public DateTime SaleDate { get; set; }
		public int Quantity { get; set; }
		public decimal Amount { get; set; }
		public string City { get; set; }
	}
}
