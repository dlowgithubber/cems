using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CEMS.Core.Domain.Entities.JoiningTables
{
    public class UserRolePermissions
    {
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        public int UserRolePermissionId { get; set; }
        public UserRolePermission UserRolePermission { get; set; }
    }
}
