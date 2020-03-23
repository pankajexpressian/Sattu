using System;
using System.Collections.Generic;

namespace Sattu.Domain
{
    public class Cart : EntityBase
    {

        public Guid Id { get; set; }
        public IEnumerable<Item> Item { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Units { get; set; }
        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }


}
