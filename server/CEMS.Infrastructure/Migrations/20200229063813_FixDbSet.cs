using Microsoft.EntityFrameworkCore.Migrations;

namespace CEMS.Infrastructure.Migrations
{
    public partial class FixDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "UserAction",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "UserAction",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "UserAction",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "UserAction",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserActionToDo_Content",
                table: "UserAction",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "UserAction");

            migrationBuilder.DropColumn(
                name: "Body",
                table: "UserAction");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "UserAction");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "UserAction");

            migrationBuilder.DropColumn(
                name: "UserActionToDo_Content",
                table: "UserAction");
        }
    }
}
