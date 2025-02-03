using InventoryManagement.Application.Interfaces;
using InventoryManagement.Domain.Entities;

namespace InventoryManagement.Application.UseCases
{
    public class ProductService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync() => await _productRepository.GetAllAsync();

        public async Task<Product?> GetProductByIdAsync(int id) => await _productRepository.GetByIdAsync(id);

        public async Task AddProductAsync(Product product) => await _productRepository.AddAsync(product);

        public void UpdateProduct(Product product) => _productRepository.Update(product);

        public void DeleteProduct(Product product) => _productRepository.Delete(product);
    }
}
