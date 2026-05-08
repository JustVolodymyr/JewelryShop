namespace Server.Entities
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? Description { get; set; }
		public decimal BasePrice { get; set; }
		public bool IsActive { get; set; } = true;
		public DateTime CreatedAt { get; set; }
	}
}
