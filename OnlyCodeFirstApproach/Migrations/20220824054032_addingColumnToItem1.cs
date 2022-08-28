using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlyCodeFirstApproach.Migrations
{
    public partial class addingColumnToItem1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Items",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Items");
        }
    }
}
