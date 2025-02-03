using InventoryManagement.Application.Interfaces;
using InventoryManagement.Domain.Entities;

namespace InventoryManagement.Application.UseCases
{
    public class SupplierService
    {
        private readonly IRepository<Supplier> _supplierRepository;

        public SupplierService(IRepository<Supplier> supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync() => await _supplierRepository.GetAllAsync();

        public async Task<Supplier?> GetSupplierByIdAsync(int id) => await _supplierRepository.GetByIdAsync(id);

        public async Task AddSupplierAsync(Supplier supplier) => await _supplierRepository.AddAsync(supplier);

        public void UpdateSupplier(Supplier supplier) => _supplierRepository.Update(supplier);

        public void DeleteSupplier(Supplier supplier) => _supplierRepository.Delete(supplier);
    }
}
