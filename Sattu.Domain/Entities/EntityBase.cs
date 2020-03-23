using System;

namespace Sattu.Domain
{
    public abstract class EntityBase
    {
        public abstract bool Validate();
        public bool Active { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

    }


}
