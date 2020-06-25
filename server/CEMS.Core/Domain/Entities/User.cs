using CEMS.Core.Domain.Entities.AbstractEntities;
using CEMS.Core.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    public class User : IDeletable, IRowVersion
    {
        [Key]
        public string UserId { get; set; }
        public string Name { get; set; }
        public bool IsSuperUser { get; set; }
        public bool MFAEnabled { get; set; }

        public string TOTPSecret { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }

        public bool IsInitialised { get; set; }
        public bool IsDeleted { get; set; }
        public Organisation Organisation { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
