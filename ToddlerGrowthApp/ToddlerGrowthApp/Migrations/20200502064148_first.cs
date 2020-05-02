using Microsoft.EntityFrameworkCore.Migrations;

namespace ToddlerGrowthApp.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsedItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(maxLength: 100, nullable: false),
                    ItemColor = table.Column<string>(maxLength: 250, nullable: false),
                    ItemDescription = table.Column<string>(nullable: false),
                    ItemPrice = table.Column<decimal>(nullable: false),
                    ItemType = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedItems", x => x.ItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsedItems");
        }
    }
}
