using Net.Coffee.Library.Core;
using System;
using System.Linq;
using Unity;

namespace Net.Coffee.Client
{
    public class Startup : IStartup
    {
        public void ConfigureServices(IUnityContainer container)
        {
            container.RegisterSingleton<ViewMain, ViewMain>();
            container.RegisterType<IViewLocker, ViewLocker>();
        }
    }
}
