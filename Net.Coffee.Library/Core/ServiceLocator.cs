using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Net.Coffee.Library.Core
{
    public static class ServiceLocator
    {

        private static IUnityContainer container;
        static ServiceLocator()
        {
            container = IoCFactory.Create();
        }
        public static T GetService<T>()
        {
            return container.Resolve<T>();
        }
    }
}
