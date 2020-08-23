using System;
using System.Linq;
using Unity;

namespace Net.Coffee.Library.Core
{
    public interface IStartup
    {
        void ConfigureServices(IUnityContainer container);
    }
}
