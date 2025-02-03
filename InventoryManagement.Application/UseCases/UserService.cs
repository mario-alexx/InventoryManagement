using InventoryManagement.Application.Interfaces;
using InventoryManagement.Domain.Entities;

namespace InventoryManagement.Application.UseCases
{
    public class UserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync() => await _userRepository.GetAllAsync();

        public async Task<User?> GetUserByIdAsync(int id) => await _userRepository.GetByIdAsync(id);

        public async Task AddUserAsync(User user) => await _userRepository.AddAsync(user);

        public void UpdateUser(User user) => _userRepository.Update(user);

        public void DeleteUser(User user) => _userRepository.Delete(user);
    }
}
