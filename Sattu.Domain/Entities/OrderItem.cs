using System.Collections.Generic;

namespace Sattu.Domain
{
    public class OrderItem
    {

        public int Id { get; set; }
        public IEnumerable<Item> Item { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Units { get; set; }
    }


}
