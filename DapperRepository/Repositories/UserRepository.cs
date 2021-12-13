using Dapper;
using DapperRepository.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperRepository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbSession _db;
        public UserRepository(DbSession dbSession)
        {
            _db = dbSession;
        }

        public async Task<List<User>> GetAllAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM users";
                List<User> users = (await conn.QueryAsync<User>(sql: query)).ToList(); 
                return users;
            }
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAsync(User newUser)
        {
            throw new System.NotImplementedException();
        }
        public Task<bool> DeleteAsync(User updatedUser)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateAsync(User updatedUser)
        {
            throw new System.NotImplementedException();
        }
    }
}
