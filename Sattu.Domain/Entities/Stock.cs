using System;

namespace Sattu.Domain
{
    public class Stock : EntityBase
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Units { get; set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }


}
