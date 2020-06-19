using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CEMS.Core.Domain.Entities;
using CEMS.Core.Domain.Entities.JoiningTables;

namespace CEMS.Infrastructure.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ClientOrganisation> ClientOrganisations { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserActionEmail> UserActionEmails {get; set;}
        public DbSet<UserActionProcess> UserActionProcesses { get; set; }
        public DbSet<UserActionToDo> UserActionToDos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AssociatedSiteAction>().HasKey(asa => new { asa.SiteId, asa.UserActionId});
        }
    }
}
