using InventoryManagement.Domain.Entities;

namespace InventoryManagement.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> Products { get; }
        IRepository<Inventory> Inventories { get; }
        IRepository<User> Users { get; }
        IRepository<Category> Categories { get; }
        IRepository<Supplier> Suppliers { get; }
        Task<int> CompleteAsync();
    }
}
