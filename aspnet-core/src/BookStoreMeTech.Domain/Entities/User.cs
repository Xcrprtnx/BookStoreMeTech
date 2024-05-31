using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookStoreMeTech
{
    public class User : FullAuditedAggregateRoot<Guid>
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }

        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string SecurityStamp { get; set; }

        public string Bio { get; set; }
        public bool EmailConfirmed { get; set; }
        public Guid? TenantId { get; set; }

        public User()
        {
           
        }
    }
}
