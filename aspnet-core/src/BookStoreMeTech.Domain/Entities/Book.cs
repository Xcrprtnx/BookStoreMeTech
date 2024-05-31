using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookStoreMeTech
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public decimal Price { get; set; }
        public double AverageRating { get; set; }
        public ICollection<Review> Reviews { get; set; }

        
        public Book()
        {
            Reviews = new List<Review>();
        }
    }
}
