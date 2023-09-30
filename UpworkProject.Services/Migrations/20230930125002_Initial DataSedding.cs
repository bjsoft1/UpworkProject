using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpworkProject.Services.Migrations
{
    public partial class InitialDataSedding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 2,
                column: "Options",
                value: "Male,Female");

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 3,
                column: "Options",
                value: "Music,Movies,Sports");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 2,
                column: "Options",
                value: "");

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 3,
                column: "Options",
                value: "");
        }
    }
}
