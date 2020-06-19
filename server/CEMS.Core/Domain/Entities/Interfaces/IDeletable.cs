using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities.Interfaces
{
    interface IDeletable
    {
        public bool IsDeleted { get; set; }
    }
}
