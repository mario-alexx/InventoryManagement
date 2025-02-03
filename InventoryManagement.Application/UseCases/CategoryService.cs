using InventoryManagement.Application.Interfaces;
using InventoryManagement.Domain.Entities;

namespace InventoryManagement.Application.UseCases
{
    public class CategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync() => await _categoryRepository.GetAllAsync();

        public async Task<Category?> GetCategoryByIdAsync(int id) => await _categoryRepository.GetByIdAsync(id);

        public async Task AddCategoryAsync(Category category) => await _categoryRepository.AddAsync(category);

        public void UpdateCategory(Category category) => _categoryRepository.Update(category);

        public void DeleteCategory(Category category) => _categoryRepository.Delete(category);
    }
}
