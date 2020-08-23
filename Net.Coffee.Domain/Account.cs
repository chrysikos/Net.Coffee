using System;

namespace Net.Coffee.Domain
{
    public class Account
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public Money Balance { get; set; }
    }
}
