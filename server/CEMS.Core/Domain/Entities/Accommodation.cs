using CEMS.Core.Domain.Entities.AbstractEntities;
using CEMS.Core.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    public class Accommodation : ModifiableEntity<int>, IDeletable, IArchivable
    {
        public string Name { get; set; }
        public int MaxPersons { get; set; }
        public string Notes { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }

        public Site Site { get; set; }
    }
}
