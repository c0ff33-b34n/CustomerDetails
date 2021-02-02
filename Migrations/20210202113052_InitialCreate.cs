using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerDetails.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BusinessName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    BuildingName = table.Column<string>(type: "TEXT", maxLength: 35, nullable: true),
                    NumberAndStreet = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    LocalityName = table.Column<string>(type: "TEXT", maxLength: 35, nullable: true),
                    TownOrCity = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    County = table.Column<string>(type: "TEXT", maxLength: 35, nullable: false),
                    PostCode = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
