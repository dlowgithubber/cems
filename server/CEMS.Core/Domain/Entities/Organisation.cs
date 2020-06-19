using CEMS.Core.Domain.Entities.AbstractEntities;
using CEMS.Core.Domain.Entities.Interfaces;
using System.Collections.Generic;

namespace CEMS.Core.Domain.Entities
{
    public class Organisation : Entity<int>, IDeletable
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Site> Sites { get; set; }
    }
}
