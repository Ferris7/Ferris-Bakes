using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ferris_Bakes.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bake = table.Column<string>(nullable: true),
                    flavor = table.Column<string>(nullable: true),
                    size = table.Column<int>(nullable: false),
                    Frosting = table.Column<string>(nullable: true),
                    filling = table.Column<bool>(nullable: false),
                    fillFlavor = table.Column<string>(nullable: true),
                    comment = table.Column<string>(nullable: true),
                    customerFirstName = table.Column<string>(nullable: true),
                    customerLastName = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    dueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderNumber);
                });

            migrationBuilder.CreateTable(
                name: "SetOrder",
                columns: table => new
                {
                    BakeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakeName = table.Column<string>(nullable: true),
                    BakeType = table.Column<string>(nullable: true),
                    Flavor = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Frosting = table.Column<string>(nullable: true),
                    FillFlavor = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetOrder", x => x.BakeID);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ItemId = table.Column<string>(nullable: false),
                    CartId = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Cart_SetOrder_ProductId",
                        column: x => x.ProductId,
                        principalTable: "SetOrder",
                        principalColumn: "BakeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "SetOrder");
        }
    }
}
