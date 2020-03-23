using System;

namespace Sattu.Domain
{
    public class Customer : EntityBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; private set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int? ShippingAddressId { get; set; }
        public int? BillingAddressId { get; set; }
        public string UserId { get; set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }


}
