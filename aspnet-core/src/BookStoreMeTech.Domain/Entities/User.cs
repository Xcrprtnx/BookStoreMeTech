using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookStoreMeTech.Entities
{
    public class User : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {

        }
    }
}
