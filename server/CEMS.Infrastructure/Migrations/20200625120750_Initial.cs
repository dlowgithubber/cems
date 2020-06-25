using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CEMS.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Permission = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRolePermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IsSuperUser = table.Column<bool>(nullable: false),
                    MFAEnabled = table.Column<bool>(nullable: false),
                    TOTPSecret = table.Column<string>(nullable: false),
                    PasswordSalt = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    IsInitialised = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OrganisationId = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Organisations_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedById = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByUserId = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    OrganisationId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsArchived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Users_LastModifiedByUserId",
                        column: x => x.LastModifiedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Organisations_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedById = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByUserId = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Nickname = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<char>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    TenanusShotDate = table.Column<DateTime>(nullable: false),
                    ShirtSize = table.Column<string>(nullable: false),
                    MedicareNumber = table.Column<string>(nullable: false),
                    MedicareExpiryDate = table.Column<string>(nullable: false),
                    HealthcareCardNumber = table.Column<string>(nullable: false),
                    WWCC = table.Column<string>(nullable: false),
                    WWCCExpiryDate = table.Column<DateTime>(nullable: false),
                    HasFirstAidCertificate = table.Column<bool>(nullable: false),
                    FirstAidExpiryDate = table.Column<DateTime>(nullable: true),
                    SchoolAttending = table.Column<string>(nullable: false),
                    SchoolYear = table.Column<int>(nullable: false),
                    AllowedParacetamol = table.Column<bool>(nullable: false),
                    AllowedAntihistamine = table.Column<bool>(nullable: false),
                    AllowedIbuprofen = table.Column<bool>(nullable: false),
                    AllowedToGoSwimming = table.Column<bool>(nullable: false),
                    ReasonForNotSwimming = table.Column<string>(nullable: false),
                    SwimmingProficiency = table.Column<int>(nullable: false),
                    HasMedicalConditions = table.Column<bool>(nullable: false),
                    PermissionGiven = table.Column<bool>(nullable: false),
                    NameOfPermissionGiver = table.Column<string>(nullable: false),
                    PermissionGiverRelationToPerson = table.Column<string>(nullable: false),
                    IsAllowedInMedia = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsArchived = table.Column<bool>(nullable: false),
                    OrganisationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_Users_LastModifiedByUserId",
                        column: x => x.LastModifiedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Organisations_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedById = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByUserId = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IsArchived = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OrganisationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sites_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sites_Users_LastModifiedByUserId",
                        column: x => x.LastModifiedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sites_Organisations_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "Organisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedById = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByUserId = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_LastModifiedByUserId",
                        column: x => x.LastModifiedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(nullable: false),
                    IPAddress = table.Column<string>(nullable: false),
                    ExpiryDateTime = table.Column<DateTime>(nullable: false),
                    LastAccessTime = table.Column<DateTime>(nullable: false),
                    DeviceInfo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accommodations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedById = table.Column<int>(nullable: false),
                    CreatedByUserId = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedByUserId = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    MaxPersons = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsArchived = table.Column<bool>(nullable: false),
                    SiteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accommodations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accommodations_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accommodations_Users_LastModifiedByUserId",
                        column: x => x.LastModifiedByUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accommodations_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRolePermissionsList",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false),
                    UserRolePermissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRolePermissionsList", x => new { x.UserRoleId, x.UserRolePermissionId });
                    table.ForeignKey(
                        name: "FK_UserRolePermissionsList_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRolePermissionsList_UserRolePermissions_UserRolePermiss~",
                        column: x => x.UserRolePermissionId,
                        principalTable: "UserRolePermissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRolesList",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    UserRoleId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRolesList", x => new { x.UserId, x.UserRoleId });
                    table.ForeignKey(
                        name: "FK_UserRolesList_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRolesList_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Organisations",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 1, false, "Camp Fun Place To Be" });

            migrationBuilder.InsertData(
                table: "UserRolePermissions",
                columns: new[] { "Id", "Permission" },
                values: new object[,]
                {
                    { 17, 16 },
                    { 16, 15 },
                    { 15, 14 },
                    { 14, 13 },
                    { 13, 12 },
                    { 12, 11 },
                    { 11, 10 },
                    { 10, 9 },
                    { 9, 8 },
                    { 8, 7 },
                    { 7, 6 },
                    { 6, 5 },
                    { 5, 4 },
                    { 4, 3 },
                    { 3, 2 },
                    { 2, 1 },
                    { 1, 0 },
                    { 18, 17 },
                    { 19, 18 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "IsDeleted", "IsInitialised", "IsSuperUser", "MFAEnabled", "Name", "OrganisationId", "PasswordHash", "PasswordSalt", "TOTPSecret", "RowVersion" },
                values: new object[] { "superuser", false, false, true, true, "", 1, "", "", "", new byte[] {0x01, 0x12 } });

            migrationBuilder.CreateIndex(
                name: "IX_Accommodations_CreatedByUserId",
                table: "Accommodations",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Accommodations_LastModifiedByUserId",
                table: "Accommodations",
                column: "LastModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Accommodations_SiteId",
                table: "Accommodations",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CreatedByUserId",
                table: "Events",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_LastModifiedByUserId",
                table: "Events",
                column: "LastModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganisationId",
                table: "Events",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CreatedByUserId",
                table: "Persons",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_LastModifiedByUserId",
                table: "Persons",
                column: "LastModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_OrganisationId",
                table: "Persons",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_CreatedByUserId",
                table: "Sites",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_LastModifiedByUserId",
                table: "Sites",
                column: "LastModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_OrganisationId",
                table: "Sites",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRolePermissionsList_UserRolePermissionId",
                table: "UserRolePermissionsList",
                column: "UserRolePermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_CreatedByUserId",
                table: "UserRoles",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_LastModifiedByUserId",
                table: "UserRoles",
                column: "LastModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRolesList_UserId1",
                table: "UserRolesList",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserRolesList_UserRoleId",
                table: "UserRolesList",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganisationId",
                table: "Users",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTokens_UserId",
                table: "UserTokens",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accommodations");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "UserRolePermissionsList");

            migrationBuilder.DropTable(
                name: "UserRolesList");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "UserRolePermissions");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organisations");
        }
    }
}
