using System;
using System.Collections.Generic;
using test.Domain.Common;
using test.Domain.ValueObjects;

namespace test.Domain.Entities
{
    public class Order: AuditableEntity
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public DateTime Date { get; set; }

        public IList<OrderPosition> OrderPosition { get; set; } = new List<OrderPosition>(); 
 
    }
}
