﻿using System;
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
                    filling = table.Column<bool>(nullable: false),
                    fillFlavor = table.Column<int>(nullable: false),
                    comment = table.Column<string>(nullable: true),
                    customerName = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    dueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
