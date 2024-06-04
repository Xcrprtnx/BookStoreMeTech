using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookStoreMeTech.Entities
{
    public class Review : AuditedEntity<Guid>
    {
        public Guid BookId { get; set; }
        public Book? Book { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public string Comment { get; set; }
        public int Rating { get; set; }

        public Review()
        {
        }
    }
}
