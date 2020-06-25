using CEMS.Core.Domain.Entities.AbstractEntities;
using CEMS.Core.Domain.Entities.JoiningTables;
using CEMS.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    public class UserRolePermission : Entity<int>
    {
        // These are hardcoded and don't belong to any organisation in particular.
        public UserRolePermissionTypes Permission { get; set; }
        
        public ICollection<UserRolePermissions> UserRolePermissions { get; set; }
    }
}
