using System;
using System.Linq;

namespace Net.Coffee.Server.Contracts
{
    public class DTOAccount
    {
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public short Number { get; set; }
        public string PostalCode { get; set; }
        public string CellPhone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Discount { get; set; }
    }
}
