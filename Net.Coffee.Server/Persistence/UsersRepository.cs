using Microsoft.EntityFrameworkCore;
using Net.Coffee.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net.Coffee.Server.Persistence
{
    public class UsersRepository : IUsersRepository
    {
        public MyDbContext myDbContext;
        public UsersRepository(
            MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await myDbContext.Users.ToListAsync();
        }
        public async Task<User> AddAsync(User user)
        {
            user.ID = Guid.Empty;
            var entry = await this.myDbContext.AddAsync<User>(user);
            return entry.Entity;
        }
        public async Task<User> GetByIdAsync(Guid id)
        {
            return await this.myDbContext.FindAsync<User>(id);
        }

        public async Task<User> GetByCredentialsUsernameAsync(string username)
        {
            return await this.myDbContext.Users.Where(x => x.Credentials.Username == username).FirstOrDefaultAsync();
        }

        public void Remove(User user)
        {
            myDbContext.Users.Remove(user);
        }
    }
}
