using InventoryManagement.Application.Interfaces;
using InventoryManagement.Domain.Entities;

namespace InventoryManagement.Application.UseCases
{
    public class InventoryService
    {
        private readonly IRepository<Inventory> _inventoryRepository;

        public InventoryService(IRepository<Inventory> inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> GetAllInventoriesAsync() => await _inventoryRepository.GetAllAsync();

        public async Task<Inventory?> GetInventoryByIdAsync(int id) => await _inventoryRepository.GetByIdAsync(id);

        public async Task AddInventoryAsync(Inventory inventory) => await _inventoryRepository.AddAsync(inventory);

        public void UpdateInventory(Inventory inventory) => _inventoryRepository.Update(inventory);

        public void DeleteInventory(Inventory inventory) => _inventoryRepository.Delete(inventory);
    }
}
