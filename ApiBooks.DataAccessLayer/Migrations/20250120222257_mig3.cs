using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBooks.DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryStatus",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CategoryStatus",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
