using CEMS.Core.Domain.Entities.AbstractEntities;
using CEMS.Core.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.Domain.Entities
{
    public class Person : ModifiableEntity<int>, IDeletable, IArchivable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string EmailAddress { get; set; }
        public DateTime TenanusShotDate { get; set; }
        public string ShirtSize { get; set; }
        public string MedicareNumber { get; set; }
        // Not sure if it should be a DateTime
        public string MedicareExpiryDate { get; set; }
        public string HealthcareCardNumber { get; set; }
        public string WWCC { get; set; }
        public DateTime WWCCExpiryDate { get; set; }
        // Could possibly go under skills
        public bool HasFirstAidCertificate { get; set; }
        public DateTime? FirstAidExpiryDate { get; set; }
        public string SchoolAttending { get; set; }
        public int SchoolYear { get; set; }
        public bool AllowedParacetamol { get; set; }
        public bool AllowedAntihistamine { get; set; }
        public bool AllowedIbuprofen { get; set; }
        public bool AllowedToGoSwimming { get; set; }
        public string ReasonForNotSwimming { get; set; }
        public int SwimmingProficiency { get; set; }
        public bool HasMedicalConditions { get; set; }
        public bool PermissionGiven { get; set; }
        public string NameOfPermissionGiver { get; set; }
        public string PermissionGiverRelationToPerson { get; set; }
        public bool IsAllowedInMedia { get; set; }
        public string Notes { get; set; }
        public bool IsVerified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsArchived { get; set; }
        public Organisation Organisation { get; set; }
    }
}
