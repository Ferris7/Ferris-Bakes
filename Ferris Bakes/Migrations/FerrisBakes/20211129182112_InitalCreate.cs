using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ferris_Bakes.Migrations.FerrisBakes
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SetOrder = table.Column<bool>(type: "bit", nullable: false),
                    RecipeOrder = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImgPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.ItemId);
                });

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
                name: "CustomOrders",
                columns: table => new
                {
                    CustomBakeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flavor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Frosting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filling = table.Column<bool>(type: "bit", nullable: false),
                    FillFlavor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomOrders", x => x.CustomBakeID);
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
                name: "SetOrderList",
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
                    table.PrimaryKey("PK_SetOrderList", x => x.BakeID);
                });

            migrationBuilder.CreateTable(
                name: "SetOrders",
                columns: table => new
                {
                    DBkey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderConfirmation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetOrder = table.Column<bool>(type: "bit", nullable: false),
                    RecipeOrder = table.Column<bool>(type: "bit", nullable: false),
                    SetOrderId = table.Column<int>(type: "int", nullable: false),
                    RecipeOrderId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePlaced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetOrders", x => x.DBkey);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "CustomOrders");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "ReciepeBook");

            migrationBuilder.DropTable(
                name: "Reciepes");

            migrationBuilder.DropTable(
                name: "SetOrderList");

            migrationBuilder.DropTable(
                name: "SetOrders");
        }
    }
}
