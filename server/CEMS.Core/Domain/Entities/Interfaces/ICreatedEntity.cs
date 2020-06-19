using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities.Interfaces
{
    interface ICreatedEntity
    {
        public User CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
