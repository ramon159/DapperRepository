using DapperRepository.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperRepository.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<bool> SaveAsync(User newUser);
        Task<bool> UpdateAsync(User updatedUser);
        Task<bool> DeleteAsync(User updatedUser);

    }
}
