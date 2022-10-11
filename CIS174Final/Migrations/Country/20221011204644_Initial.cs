using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CIS174Final.Migrations.Country
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "para", "Paralympics" },
                    { "summer", "Summer Olympics" },
                    { "winter", "Winter Olympics" },
                    { "youth", "Youth Olympics" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "FlagImage", "GameID", "Name" },
                values: new object[,]
                {
                    { "aus", "outdoor", "at.png", "para", "Austria" },
                    { "brz", "outdoor", "br.png", "summer", "Brazil" },
                    { "can", "indoor", "ca.png", "winter", "Canada" },
                    { "chi", "indoor", "cn.png", "summer", "Germany" },
                    { "cyp", "indoor", "cy.png", "youth", "Cyprus" },
                    { "fin", "outdoor", "fi.png", "youth", "Finland" },
                    { "fra", "indoor", "fr.png", "youth", "France" },
                    { "gbe", "indoor", "gb.png", "winter", "Great Britain" },
                    { "ger", "indoor", "de.png", "summer", "Germany" },
                    { "ita", "outdoor", "it.png", "winter", "Italy" },
                    { "jam", "outdoor", "jm.png", "winter", "Jamaica" },
                    { "jap", "outdoor", "jp.png", "winter", "Japan" },
                    { "mex", "indoor", "mx.png", "summer", "Germany" },
                    { "ndr", "outdoor", "nl.png", "summer", "Netherlands" },
                    { "pak", "outdoor", "pk.png", "para", "Pakistan" },
                    { "por", "outdoor", "pt.png", "youth", "Portugal" },
                    { "rus", "indoor", "ru.png", "youth", "Russia" },
                    { "slv", "outdoor", "sk.png", "youth", "Slovakia" },
                    { "swe", "indoor", "se.png", "winter", "Sweden" },
                    { "tha", "indoor", "th.png", "para", "Thailand" },
                    { "ukr", "indoor", "ua.png", "para", "Ukraine" },
                    { "uru", "indoor", "uy.png", "para", "Uruguay" },
                    { "usa", "outdoor", "us.png", "summer", "United States" },
                    { "zim", "outdoor", "zw.png", "para", "Zimbabwe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryID",
                table: "Countries",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
