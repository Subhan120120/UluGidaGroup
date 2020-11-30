using Microsoft.EntityFrameworkCore.Migrations;

namespace UluGidaGroup.Migrations
{
    public partial class addedUluContextAppDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebTitle = table.Column<string>(maxLength: 30, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(maxLength: 100, nullable: true),
                    Twitter = table.Column<string>(maxLength: 100, nullable: true),
                    Instagram = table.Column<string>(maxLength: 100, nullable: true),
                    About = table.Column<string>(maxLength: 190, nullable: true),
                    Heading = table.Column<string>(maxLength: 30, nullable: true),
                    SubHeading = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppDetails");
        }
    }
}
