using Microsoft.EntityFrameworkCore.Migrations;

namespace CalendarAPI.Migrations
{
    public partial class updatedeventmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activity",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CalendarEvents");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CalendarEvents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "CalendarEvents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CalendarEvents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CalendarEvents");

            migrationBuilder.AddColumn<string>(
                name: "Activity",
                table: "CalendarEvents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CalendarEvents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
