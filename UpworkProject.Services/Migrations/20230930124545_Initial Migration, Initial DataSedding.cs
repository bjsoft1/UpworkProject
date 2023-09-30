using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UpworkProject.Services.Migrations
{
    public partial class InitialMigrationInitialDataSedding : Migration
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
                    Options = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicControls", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DynamicControls",
                columns: new[] { "Id", "ControlIdentity", "ControlType", "LabelDate", "Options", "OrderNumber", "Status" },
                values: new object[] { 1, "FullName", 0, "What is your name?", "", 1, 0 });

            migrationBuilder.InsertData(
                table: "DynamicControls",
                columns: new[] { "Id", "ControlIdentity", "ControlType", "LabelDate", "Options", "OrderNumber", "Status" },
                values: new object[] { 2, "Gender", 2, "What is your gender?", "", 2, 0 });

            migrationBuilder.InsertData(
                table: "DynamicControls",
                columns: new[] { "Id", "ControlIdentity", "ControlType", "LabelDate", "Options", "OrderNumber", "Status" },
                values: new object[] { 3, "Hobbies", 1, "What is your hobbies?", "", 3, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DynamicControls");
        }
    }
}
