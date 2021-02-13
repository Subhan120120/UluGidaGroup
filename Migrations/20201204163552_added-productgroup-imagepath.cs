using Microsoft.EntityFrameworkCore.Migrations;

namespace UluGidaGroup.Migrations
{
    public partial class addedproductgroupimagepath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductGroupName",
                table: "ProductGroups",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "ProductGroups",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "ProductGroups");

            migrationBuilder.AlterColumn<string>(
                name: "ProductGroupName",
                table: "ProductGroups",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
