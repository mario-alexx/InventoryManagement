using InventoryManagement.Application.Interfaces;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Infrastrucure.Persistence.Repositories;

namespace InventoryManagement.Infrastrucure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public IRepository<Product> Products { get; }

        public IRepository<Inventory> Inventories { get; }

        public IRepository<User> Users { get; }

        public IRepository<Category> Categories { get; }

        public IRepository<Supplier> Suppliers { get; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Products = new Repository<Product>(dbContext);
            Categories = new Repository<Category>(dbContext);
            Inventories = new Repository<Inventory>(dbContext);
            Users = new Repository<User>(dbContext);
            Suppliers = new Repository<Supplier>(dbContext);
        }

        public async Task<int> CompleteAsync() => await _dbContext.SaveChangesAsync();
    }
}
