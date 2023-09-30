using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpworkProject.Services.Migrations
{
    public partial class AddMoreDataSeddingUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ControlIdentity", "LabelDate" },
                values: new object[] { "CurrentDateTime", "What is your current date time?" });

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ControlIdentity", "LabelDate" },
                values: new object[] { "CurrentDate", "What is your current date?" });

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ControlIdentity", "LabelDate" },
                values: new object[] { "CurrentTime", "What is your current time?" });

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ControlIdentity", "OrderNumber" },
                values: new object[] { "Message", 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ControlIdentity", "LabelDate" },
                values: new object[] { "FullName", "What is your name?" });

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ControlIdentity", "LabelDate" },
                values: new object[] { "FullName", "What is your name?" });

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ControlIdentity", "LabelDate" },
                values: new object[] { "FullName", "What is your name?" });

            migrationBuilder.UpdateData(
                table: "DynamicControls",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ControlIdentity", "OrderNumber" },
                values: new object[] { "FullName", 1 });
        }
    }
}
