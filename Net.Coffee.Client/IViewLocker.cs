using System;
using System.Linq;

namespace Net.Coffee.Client
{
    public interface IViewLocker
    {
        void Lock();
        void UnLock();
    }
}