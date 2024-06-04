using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookStoreMeTech.Entities
{
    public class User : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public User()
        {
            Reviews = new List<Review>();
        }
    }
}
