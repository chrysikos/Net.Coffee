using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net.Coffee.Server.Model
{
    public class UserDTO
    {
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactCellPhone { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddressCity { get; set; }
        public string ContactAddressStreet { get; set; }
        public short ContactAddressNumber { get; set; }
        public string ContactAddressPostalCode { get; set; }
        public string CredentialsUsername { get; set; }
        public string CredentialsPassword { get; set; }
    }
}
