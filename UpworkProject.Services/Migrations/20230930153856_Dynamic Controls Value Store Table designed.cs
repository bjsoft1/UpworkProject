using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpworkProject.Services.Migrations
{
    public partial class DynamicControlsValueStoreTabledesigned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParticipaintInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipaintInformations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 4,
                column: "ControlIdentity",
                value: "Country");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParticipaintInformations");

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 4,
                column: "ControlIdentity",
                value: "select");
        }
    }
}
