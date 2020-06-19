using CEMS.Core.Domain.Entities.AbstractEntities;
using CEMS.Core.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    public class Site : ModifiableEntity<int>, IDeletable, IArchivable
    {
        public string Name { get; set; }

        //public int AddressId { get; set; }
        //public Address Address { get; set; }
        public bool IsArchived { get; set; }
        public bool IsDeleted { get; set; }
        public int OrganisationId { get; set; }
        public Organisation Organisation { get; set; }

        public ICollection<Accommodation> Accommodations { get; set; }
    }
}
