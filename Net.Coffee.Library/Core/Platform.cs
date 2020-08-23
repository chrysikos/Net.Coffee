using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Net.Coffee.Library.Core
{
    public static class Platform
    {
        public static void Initialize<T>() where T : class, IStartup, new()
        {
            T startup = new T();
            var container = IoCFactory.Create();
            startup.ConfigureServices(container);
        }
        public static void InitializeWithCoreServices<T>() where T : class, IStartup, new()
        {
            T startup = new T();
            var container = IoCFactory.Create();
            CoreServiceCollection.ConfigureServices(container);
            startup.ConfigureServices(container);
        }
    }
}
