using System;

namespace Sattu.Domain
{
    public class Item : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get { return StockCount > 0; } }
        public int StockCount { get; set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }


}
