using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities.Interfaces
{
    interface IModifiableEntity
    {
        public User? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
