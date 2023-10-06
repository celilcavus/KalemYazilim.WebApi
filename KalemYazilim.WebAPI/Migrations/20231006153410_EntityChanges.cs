using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KalemYazilim.WebAPI.Migrations
{
    public partial class EntityChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Malzeme",
                table: "SatisFaturaSatiri",
                newName: "MalzemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MalzemeId",
                table: "SatisFaturaSatiri",
                newName: "Malzeme");
        }
    }
}
