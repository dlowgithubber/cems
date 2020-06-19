using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities.Interfaces
{
    interface IArchivable
    {
        public bool IsArchived { get; set; }
    }
}
