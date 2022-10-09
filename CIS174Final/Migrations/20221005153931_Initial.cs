using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CIS174Final.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestStudents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TestStudents",
                columns: new[] { "Id", "FirstName", "Grade", "LastName" },
                values: new object[,]
                {
                    { 1, "Test1", "10", "Name1" },
                    { 2, "Test2", "9", "Name2" },
                    { 3, "Test3", "5", "Name3" },
                    { 4, "Test4", "1", "Name4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestStudents");
        }
    }
}
