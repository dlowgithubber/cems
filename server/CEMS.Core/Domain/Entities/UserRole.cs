using CEMS.Core.Domain.Entities.AbstractEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    class UserRole : ModifiableEntity<int>
    {
        public string Name { get; set; }
    }
}
