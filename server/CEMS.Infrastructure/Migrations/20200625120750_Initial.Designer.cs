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
    [Migration("20200625120750_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Accommodation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CreatedById")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastModifiedByUserId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("MaxPersons")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastModifiedByUserId");

                    b.HasIndex("SiteId");

                    b.ToTable("Accommodations");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CreatedById")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastModifiedByUserId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

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

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastModifiedByUserId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.JoiningTables.UserRolePermissions", b =>
                {
                    b.Property<int>("UserRoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserRolePermissionId")
                        .HasColumnType("integer");

                    b.HasKey("UserRoleId", "UserRolePermissionId");

                    b.HasIndex("UserRolePermissionId");

                    b.ToTable("UserRolePermissionsList");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.JoiningTables.UserRoles", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("integer");

                    b.Property<string>("UserId1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId", "UserRoleId");

                    b.HasIndex("UserId1");

                    b.HasIndex("UserRoleId");

                    b.ToTable("UserRolesList");
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Camp Fun Place To Be"
                        });
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("AllowedAntihistamine")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowedIbuprofen")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowedParacetamol")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowedToGoSwimming")
                        .HasColumnType("boolean");

                    b.Property<int>("CreatedById")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("FirstAidExpiryDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("Gender")
                        .HasColumnType("character(1)");

                    b.Property<bool>("HasFirstAidCertificate")
                        .HasColumnType("boolean");

                    b.Property<bool>("HasMedicalConditions")
                        .HasColumnType("boolean");

                    b.Property<string>("HealthcareCardNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAllowedInMedia")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("boolean");

                    b.Property<string>("LastModifiedByUserId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MedicareExpiryDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MedicareNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameOfPermissionGiver")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("integer");

                    b.Property<bool>("PermissionGiven")
                        .HasColumnType("boolean");

                    b.Property<string>("PermissionGiverRelationToPerson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReasonForNotSwimming")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.Property<string>("SchoolAttending")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SchoolYear")
                        .HasColumnType("integer");

                    b.Property<string>("ShirtSize")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SwimmingProficiency")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TenanusShotDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("WWCC")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("WWCCExpiryDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastModifiedByUserId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CreatedById")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastModifiedByUserId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

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

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastModifiedByUserId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsInitialised")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSuperUser")
                        .HasColumnType("boolean");

                    b.Property<bool>("MFAEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("integer");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.Property<string>("TOTPSecret")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = "superuser",
                            IsDeleted = false,
                            IsInitialised = false,
                            IsSuperUser = true,
                            MFAEnabled = true,
                            Name = "",
                            OrganisationId = 1,
                            PasswordHash = "",
                            PasswordSalt = "",
                            TOTPSecret = ""
                        });
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CreatedById")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastModifiedByUserId")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastModifiedByUserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.UserRolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Permission")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserRolePermissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Permission = 0
                        },
                        new
                        {
                            Id = 2,
                            Permission = 1
                        },
                        new
                        {
                            Id = 3,
                            Permission = 2
                        },
                        new
                        {
                            Id = 4,
                            Permission = 3
                        },
                        new
                        {
                            Id = 5,
                            Permission = 4
                        },
                        new
                        {
                            Id = 6,
                            Permission = 5
                        },
                        new
                        {
                            Id = 7,
                            Permission = 6
                        },
                        new
                        {
                            Id = 8,
                            Permission = 7
                        },
                        new
                        {
                            Id = 9,
                            Permission = 8
                        },
                        new
                        {
                            Id = 10,
                            Permission = 9
                        },
                        new
                        {
                            Id = 11,
                            Permission = 10
                        },
                        new
                        {
                            Id = 12,
                            Permission = 11
                        },
                        new
                        {
                            Id = 13,
                            Permission = 12
                        },
                        new
                        {
                            Id = 14,
                            Permission = 13
                        },
                        new
                        {
                            Id = 15,
                            Permission = 14
                        },
                        new
                        {
                            Id = 16,
                            Permission = 15
                        },
                        new
                        {
                            Id = 17,
                            Permission = 16
                        },
                        new
                        {
                            Id = 18,
                            Permission = 17
                        },
                        new
                        {
                            Id = 19,
                            Permission = 18
                        });
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.UserToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DeviceInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpiryDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastAccessTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Accommodation", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByUserId");

                    b.HasOne("CEMS.Core.Domain.Entities.Site", "Site")
                        .WithMany("Accommodations")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Event", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByUserId");

                    b.HasOne("CEMS.Core.Domain.Entities.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.JoiningTables.UserRolePermissions", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.UserRole", "UserRole")
                        .WithMany("UserRolePermissions")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.UserRolePermission", "UserRolePermission")
                        .WithMany("UserRolePermissions")
                        .HasForeignKey("UserRolePermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.JoiningTables.UserRoles", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Person", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByUserId");

                    b.HasOne("CEMS.Core.Domain.Entities.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.Site", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByUserId");

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

            modelBuilder.Entity("CEMS.Core.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEMS.Core.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedByUserId");
                });

            modelBuilder.Entity("CEMS.Core.Domain.Entities.UserToken", b =>
                {
                    b.HasOne("CEMS.Core.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
