using Net.Coffee.Library.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Net.Coffee.Server.Domain
{
    public class Account
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public Money Balance { get; set; }
    }
}
