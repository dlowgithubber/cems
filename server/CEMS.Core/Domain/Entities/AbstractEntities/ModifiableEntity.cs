using CEMS.Core.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CEMS.Core.Domain.Entities.AbstractEntities
{
    public abstract class ModifiableEntity<T>: CreatedEntity<T>, IModifiableEntity, IRowVersion
    {
        public User? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
