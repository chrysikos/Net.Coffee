using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Net.Coffee.Library.SharedKernel
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public short Number { get; set; }
        public string PostalCode { get; set; }
    }
}
