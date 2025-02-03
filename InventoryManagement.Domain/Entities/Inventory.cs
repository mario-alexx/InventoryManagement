namespace InventoryManagement.Domain.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Stock { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
