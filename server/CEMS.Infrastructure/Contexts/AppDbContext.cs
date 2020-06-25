using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CEMS.Core.Domain.Entities;
using CEMS.Core.Domain.Entities.JoiningTables;
using System.Collections.ObjectModel;
using CEMS.Core.Domain.Enums;

namespace CEMS.Infrastructure.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserRoles> UserRolesList { get; set; }
        public DbSet<UserRolePermission> UserRolePermissions { get; set; }
        public DbSet<UserRolePermissions> UserRolePermissionsList { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserRoles>().HasKey(ur => new { ur.UserId, ur.UserRoleId });
            builder.Entity<UserRolePermissions>().HasKey(urp => new { urp.UserRoleId, urp.UserRolePermissionId });
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            builder.Entity<Organisation>().HasData(new { Id = 1, Name = "Camp Fun Place To Be", IsDeleted = false, Users = new Collection<User>(), Sites = new Collection<Site>() });
            builder.Entity<User>().HasData(new { UserId = "superuser", OrganisationId = 1, Name = "", IsSuperUser = true, MFAEnabled = true, TOTPSecret = "", DateCreated = DateTime.UtcNow, PasswordSalt = "",
                PasswordHash = "", IsDeleted = false, IsInitialised = false
            });

            builder.Entity<UserRolePermission>().HasData(new { Id = 1, Permission = UserRolePermissionTypes.UsersAdminister });
            builder.Entity<UserRolePermission>().HasData(new { Id = 2, Permission = UserRolePermissionTypes.FlowsAdminister });
            builder.Entity<UserRolePermission>().HasData(new { Id = 3, Permission = UserRolePermissionTypes.PersonView });
            builder.Entity<UserRolePermission>().HasData(new { Id = 4, Permission = UserRolePermissionTypes.PersonModify });
            builder.Entity<UserRolePermission>().HasData(new { Id = 5, Permission = UserRolePermissionTypes.PersonViewSensitive });
            builder.Entity<UserRolePermission>().HasData(new { Id = 6, Permission = UserRolePermissionTypes.PersonModifySensitive });
            builder.Entity<UserRolePermission>().HasData(new { Id = 7, Permission = UserRolePermissionTypes.SiteView });
            builder.Entity<UserRolePermission>().HasData(new { Id = 8, Permission = UserRolePermissionTypes.SiteModify });
            builder.Entity<UserRolePermission>().HasData(new { Id = 9, Permission = UserRolePermissionTypes.EventView });
            builder.Entity<UserRolePermission>().HasData(new { Id = 10, Permission = UserRolePermissionTypes.EventModifyTeams });
            builder.Entity<UserRolePermission>().HasData(new { Id = 11, Permission = UserRolePermissionTypes.EventModifySites });
            builder.Entity<UserRolePermission>().HasData(new { Id = 12, Permission = UserRolePermissionTypes.ReportView });
            builder.Entity<UserRolePermission>().HasData(new { Id = 13, Permission = UserRolePermissionTypes.ReportModify });
            builder.Entity<UserRolePermission>().HasData(new { Id = 14, Permission = UserRolePermissionTypes.MutableRecordView });
            builder.Entity<UserRolePermission>().HasData(new { Id = 15, Permission = UserRolePermissionTypes.MutableRecordModify });
            builder.Entity<UserRolePermission>().HasData(new { Id = 16, Permission = UserRolePermissionTypes.MedicalRecordView });
            builder.Entity<UserRolePermission>().HasData(new { Id = 17, Permission = UserRolePermissionTypes.MedicalRecordAdd });
            builder.Entity<UserRolePermission>().HasData(new { Id = 18, Permission = UserRolePermissionTypes.IncidentReportView });
            builder.Entity<UserRolePermission>().HasData(new { Id = 19, Permission = UserRolePermissionTypes.IncidentReportAdd });
        }
    }
}
