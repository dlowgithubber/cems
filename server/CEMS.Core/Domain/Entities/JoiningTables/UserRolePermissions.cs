using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    class UserRolePermissions
    {
        public UserRole UserRole { get; set; }
        public UserRolePermission UserRolePermission { get; set; }
    }
}
