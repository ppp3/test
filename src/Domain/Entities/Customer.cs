using test.Domain.Common;
using test.Domain.ValueObjects;
using System.Collections.Generic;

namespace test.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public int Postcode { get; set; }

        public string City { get; set; }

        public IList<Order> Orders { get; private set; } = new List<Order>();


    }
}
