using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CEMS.Core.Domain.Entities.Interfaces
{
    interface IRowVersion
    {
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
