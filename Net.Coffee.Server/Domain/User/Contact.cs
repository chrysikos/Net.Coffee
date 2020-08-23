using Net.Coffee.Library.SharedKernel;
using System;
using System.Linq;

namespace Net.Coffee.Server.Domain
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string CellPhone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
