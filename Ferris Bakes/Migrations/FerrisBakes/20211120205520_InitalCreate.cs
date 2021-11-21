using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ferris_Bakes.Migrations.FerrisBakes
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.ChapterId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ReciepeID = table.Column<int>(type: "int", nullable: false),
                    Chocolate = table.Column<bool>(type: "bit", nullable: false),
                    Vanilla = table.Column<bool>(type: "bit", nullable: false),
                    Strawberry = table.Column<bool>(type: "bit", nullable: false),
                    Raspberry = table.Column<bool>(type: "bit", nullable: false),
                    Peach = table.Column<bool>(type: "bit", nullable: false),
                    Mango = table.Column<bool>(type: "bit", nullable: false),
                    Blackberry = table.Column<bool>(type: "bit", nullable: false),
                    Blueberry = table.Column<bool>(type: "bit", nullable: false),
                    RedVelvet = table.Column<bool>(type: "bit", nullable: false),
                    Lemon = table.Column<bool>(type: "bit", nullable: false),
                    Spice = table.Column<bool>(type: "bit", nullable: false),
                    Pecan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ReciepeID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flavor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<int>(type: "int", nullable: false),
                    Frosting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filling = table.Column<bool>(type: "bit", nullable: false),
                    fillFlavor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderNumber);
                });

            migrationBuilder.CreateTable(
                name: "ReciepeBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReciepeBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reciepes",
                columns: table => new
                {
                    ReciepeNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reciepes", x => x.ReciepeNumber);
                });

            migrationBuilder.CreateTable(
                name: "SetOrder",
                columns: table => new
                {
                    BakeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BakeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BakeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flavor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Frosting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FillFlavor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetOrder", x => x.BakeID);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
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
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ReciepeBook");

            migrationBuilder.DropTable(
                name: "Reciepes");

            migrationBuilder.DropTable(
                name: "SetOrder");
        }
    }
}
