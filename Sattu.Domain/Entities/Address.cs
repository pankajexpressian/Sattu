using System;

namespace Sattu.Domain
{
    public class Address : EntityBase
    {

        public int Id { get; set; }
        public bool IsShippingAddress { get; set; }
        public bool IsBillingAddress { get; set; }
        public string Zipcode { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Landmark { get; set; }
        public bool IsDefaultAddress { get; set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }


}
