using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ApiCountries.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Area = table.Column<double>(type: "double precision", nullable: false),
                    Capital = table.Column<string>(type: "text", nullable: true),
                    Region = table.Column<string>(type: "text", nullable: true),
                    Flag = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Area", "Capital", "Flag", "Name", "Region" },
                values: new object[,]
                {
                    { 1, 163610.0, "Tunis", "https://flagcdn.com/tn.svg", "Tunisia", "Africa" },
                    { 2, 43094.0, "Copenhagen", "https://flagcdn.com/dk.svg", "Denmark", "Europe" },
                    { 3, 756102.0, "Santiago", "https://flagcdn.com/cl.svg", "Chile", "Americas" },
                    { 4, 30.0, null, "https://flagcdn.com/mo.svg", "Macau", "Asia" },
                    { 5, 29743.0, "Yerevan", "https://flagcdn.com/am.svg", "Armenia", "Asia" },
                    { 6, 459.0, "Ngerulmud", "https://flagcdn.com/pw.svg", "Palau", "Oceania" },
                    { 7, 45227.0, "Tallinn", "https://flagcdn.com/ee.svg", "Estonia", "Europe" },
                    { 8, 438317.0, "Baghdad", "https://flagcdn.com/iq.svg", "Iraq", "Asia" },
                    { 9, 36193.0, "Taipei", "https://flagcdn.com/tw.svg", "Taiwan", "Asia" },
                    { 10, 51209.0, "Sarajevo", "https://flagcdn.com/ba.svg", "Bosnia and Herzegovina", "Europe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
