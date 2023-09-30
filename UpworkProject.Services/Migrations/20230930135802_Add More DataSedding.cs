using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpworkProject.Services.Migrations
{
    public partial class AddMoreDataSedding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DynamicControls",
                columns: new[] { "Id", "ControlIdentity", "ControlType", "LabelDate", "Options", "OrderNumber", "Status" },
                values: new object[,]
                {
                    { 4, "select", 3, "What is your country name?", "Nepal,India,China,USA,Korea,Japan,Pakistan", 4, 0 },
                    { 5, "FullName", 4, "What is your name?", "", 5, 0 },
                    { 6, "FullName", 5, "What is your name?", "", 6, 0 },
                    { 7, "FullName", 6, "What is your name?", "", 7, 0 },
                    { 8, "FullName", 7, "What is your message for us?", "", 8, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
