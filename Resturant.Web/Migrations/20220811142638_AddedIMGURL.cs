using Microsoft.EntityFrameworkCore.Migrations;

namespace Resturant.Web.Migrations
{
    public partial class AddedIMGURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "MenuItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "MenuItems");
        }
    }
}
