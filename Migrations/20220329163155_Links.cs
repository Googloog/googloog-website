using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sooziales_Netzwerk.Migrations
{
    public partial class Links : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "link",
                table: "Link",
                newName: "linkText");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "linkText",
                table: "Link",
                newName: "link");
        }
    }
}
