using CEMS.Core.Domain.Entities.AbstractEntities;
using CEMS.Core.Domain.Entities.JoiningTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    public class UserRole : ModifiableEntity<int>
    {
        public string Name { get; set; }
        public ICollection<UserRolePermissions> UserRolePermissions { get; set; }
    }
}
