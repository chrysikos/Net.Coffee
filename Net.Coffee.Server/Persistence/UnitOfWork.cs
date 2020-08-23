using Net.Coffee.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net.Coffee.Server.Persistence
{
    public class UnitOfWork : IDisposable
    {
        readonly MyDbContext myDbContext;
        public UnitOfWork(
            MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        public async Task SaveChangesAsync()
        {
            await this.myDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.myDbContext.Dispose();
        }
    }
}
