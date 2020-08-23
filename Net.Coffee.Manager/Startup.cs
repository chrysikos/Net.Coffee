using Net.Coffee.Library.Core;
using System;
using System.Linq;
using Unity;

namespace Net.Coffee.Manager
{
    public class Startup : IStartup
    {
        public void ConfigureServices(IUnityContainer container)
        {
            container.RegisterSingleton<ViewMain, ViewMain>();
        }
    }
}
