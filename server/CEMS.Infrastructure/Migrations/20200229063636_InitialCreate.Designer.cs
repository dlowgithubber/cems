﻿// <auto-generated />
using System;
using CEMS.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CEMS.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200229063636_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CEMS.Core.Domain.Entities.AbstractEntities.UserAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AssignedToId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedById")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateCompleted")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("FlowInstanceId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("LastModifiedById")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("AssignedToId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("LastModifiedById");

                    b.ToTable("UserAction");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Accommodation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MaxPersons")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Accommodations");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Address2")
                        .HasColumnType("text");

                    b.Property<string>("Address3")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.ClientOrganisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ABN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("OrganisationId")
                        .HasColumnType("boolean");

                    b.Property<int>("OrganisationId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrganisationId1");

                    b.ToTable("ClientOrganisations");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.JoiningTables.AssociatedSiteAction", b =>
                {
                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.Property<int>("UserActionId")
                        .HasColumnType("integer");

                    b.HasKey("SiteId", "UserActionId");

                    b.HasIndex("UserActionId");

                    b.ToTable("AssociatedSiteAction");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Organisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDefaultSite")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("integer");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.AbstractEntities.UserAction", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.User", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("AssignedToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Accommodation", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.Site", "Site")
                        .WithMany("Accommodations")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.ClientOrganisation", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.JoiningTables.AssociatedSiteAction", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.Site", "Site")
                        .WithMany("AssociatedSiteActions")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.AbstractEntities.UserAction", "UserAction")
                        .WithMany("AssociatedSiteActions")
                        .HasForeignKey("UserActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Site", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.Organisation", "Organisation")
                        .WithMany("Sites")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.User", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.Organisation", "Organisation")
                        .WithMany("Users")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}