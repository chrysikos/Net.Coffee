using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net.Coffee.Server.Domain
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> AddAsync(User user);
        Task<User> GetByIdAsync(Guid id);
    }
}
