using CEMS.Core.Domain.Entities.AbstractEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    class UserToken : Entity<int>
    {
        public User User { get; set; }
        public string IPAddress { get; set; }
        public DateTime ExpiryDateTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public string DeviceInfo { get; set; }
    }
}
