using test.Domain.Common;
using test.Domain.ValueObjects;
using System.Collections.Generic;

namespace test.Domain.Entities
{
    public class Book : AuditableEntity
    {
        public int Id { get; set; }
        public string Isbn { get; set; }

        public string Titel { get; set; }

        public string Author { get; set; }

        public int Jahr { get; set; }

    }
}
