using System;
using System.Linq;
using Unity;

namespace Net.Coffee.Library.Core
{
    public static class IoCFactory
    {
        private static IUnityContainer container;
        public static IUnityContainer Create()
        {
            if (container == null)
                container = new UnityContainer();


            return container;
        }
    }
}
