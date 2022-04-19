using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sooziales_Netzwerk.Migrations
{
    public partial class Link : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "likes",
                table: "Link");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "likes",
                table: "Link",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
