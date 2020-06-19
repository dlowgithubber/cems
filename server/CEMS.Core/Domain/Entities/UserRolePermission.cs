using CEMS.Core.Domain.Entities.AbstractEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    class UserRolePermission : Entity<int>
    {
        // These are hardcoded and don't belong to any organisation in particular.
        public string PermissionName { get; set; }
        public string PermissionValue { get; set; }
    }
}
