using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpworkProject.Repositories.Migrations
{
    public partial class modelscolumnsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DynamicControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    ControlIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LabelDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControlType = table.Column<int>(type: "int", nullable: false),
                    Options = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicControls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParticipaintInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipaintInformations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DynamicControls",
                columns: new[] { "Id", "ControlIdentity", "ControlType", "CreationTime", "LabelDate", "LastUpdateDateTime", "Options", "OrderNumber", "Status" },
                values: new object[,]
                {
                    { 1, "FullName", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is your name?", null, null, 1, 0 },
                    { 2, "Gender", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is your gender?", null, "Male,Female", 2, 0 },
                    { 3, "Hobbies", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is your hobbies?", null, "Music,Movies,Sports", 3, 0 },
                    { 4, "Country", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is your country name?", null, "Nepal,India,China,USA,Korea,Japan,Pakistan", 4, 0 },
                    { 5, "CurrentDateTime", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is your current date time?", null, null, 5, 0 },
                    { 6, "CurrentDate", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is your current date?", null, null, 6, 0 },
                    { 7, "CurrentTime", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is your current time?", null, null, 7, 0 },
                    { 8, "Message", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is your message for us?", null, null, 8, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DynamicControls");

            migrationBuilder.DropTable(
                name: "ParticipaintInformations");
        }
    }
}
