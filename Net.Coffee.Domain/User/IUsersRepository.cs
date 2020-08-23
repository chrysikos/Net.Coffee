using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net.Coffee.Domain
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> AddAsync(User user);
        Task<User> GetByIdAsync(Guid id);
        Task<User> GetByCredentialsUsernameAsync(string username);
        void Remove(User user);
    }
}
