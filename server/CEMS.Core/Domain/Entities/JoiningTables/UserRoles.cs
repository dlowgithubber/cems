using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities.JoiningTables
{
    public class UserRoles
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
    }
}
