using test.Domain.Common;
using test.Domain.ValueObjects;
using System.Collections.Generic;


namespace test.Domain.Entities
{
    public class OrderPosition : AuditableEntity
    {
        public int Id { get; set; }

        public Order Order { get; set; }

        public int OrderId { get; set; }
        
        public Book Book { get; set; }

        public int BookId { get; set; }

        
    }
}
