using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities.Interfaces
{
    interface IEntity<T>
    {
        T Id { get; set; }
    }
}
