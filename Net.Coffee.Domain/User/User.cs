using System;

namespace Net.Coffee.Domain
{
    public class User
    {
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public Contact Contact { get; set; }
        public Credentials Credentials { get; set; }
        public decimal DiscountPercentage { get; set; }
    }
}
