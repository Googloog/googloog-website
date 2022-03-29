using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sooziales_Netzwerk.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    idLink = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    link = table.Column<string>(type: "TEXT", nullable: false),
                    username = table.Column<string>(type: "TEXT", nullable: false),
                    likes = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.idLink);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Link");
        }
    }
}
