using CEMS.Core.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities.AbstractEntities
{
    public abstract class CreatedEntity<T> : Entity<T>, ICreatedEntity
    {
        public User CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
