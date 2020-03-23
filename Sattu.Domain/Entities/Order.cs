using System;
using System.Collections.Generic;

namespace Sattu.Domain
{
    public class Order : EntityBase
    {
        public int Id { get; set; }
        public DateTime? PlacedOn { get; set; }
        public int CustomerId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }


}
