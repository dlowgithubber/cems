using CEMS.Core.Domain.Entities.AbstractEntities;
using CEMS.Core.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    public class Event : ModifiableEntity<int>, IArchivable, IDeletable
    {
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Organisation Organisation { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }
    }
}
