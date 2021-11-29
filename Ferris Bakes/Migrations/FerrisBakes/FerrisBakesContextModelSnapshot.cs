﻿// <auto-generated />
using System;
using Ferris_Bakes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ferris_Bakes.Migrations.FerrisBakes
{
    [DbContext(typeof(FerrisBakesContext))]
    partial class FerrisBakesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ferris_Bakes.Entities.Chapter", b =>
                {
                    b.Property<int>("ChapterId")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChapterId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("Ferris_Bakes.Entities.Ingredients", b =>
                {
                    b.Property<int>("ReciepeID")
                        .HasColumnType("int");

                    b.Property<bool>("Blackberry")
                        .HasColumnType("bit");

                    b.Property<bool>("Blueberry")
                        .HasColumnType("bit");

                    b.Property<bool>("Chocolate")
                        .HasColumnType("bit");

                    b.Property<bool>("Lemon")
                        .HasColumnType("bit");

                    b.Property<bool>("Mango")
                        .HasColumnType("bit");

                    b.Property<bool>("Peach")
                        .HasColumnType("bit");

                    b.Property<bool>("Pecan")
                        .HasColumnType("bit");

                    b.Property<bool>("Raspberry")
                        .HasColumnType("bit");

                    b.Property<bool>("RedVelvet")
                        .HasColumnType("bit");

                    b.Property<bool>("Spice")
                        .HasColumnType("bit");

                    b.Property<bool>("Strawberry")
                        .HasColumnType("bit");

                    b.Property<bool>("Vanilla")
                        .HasColumnType("bit");

                    b.HasKey("ReciepeID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Ferris_Bakes.Models.CartItemModel", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<bool>("RecipeOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("SetOrder")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Ferris_Bakes.Models.CustomOrderModel", b =>
                {
                    b.Property<int>("CustomBakeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FillFlavor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Filling")
                        .HasColumnType("bit");

                    b.Property<string>("Flavor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frosting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("CustomBakeID");

                    b.ToTable("CustomOrders");
                });

            modelBuilder.Entity("Ferris_Bakes.Models.DatabaseSetOrder", b =>
                {
                    b.Property<int>("DBkey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatePlaced")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderConfirmation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RecipeOrder")
                        .HasColumnType("bit");

                    b.Property<int>("RecipeOrderId")
                        .HasColumnType("int");

                    b.Property<bool>("SetOrder")
                        .HasColumnType("bit");

                    b.Property<int>("SetOrderId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DBkey");

                    b.ToTable("SetOrders");
                });

            modelBuilder.Entity("Ferris_Bakes.Models.ReciepeBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReciepeBook");
                });

            modelBuilder.Entity("Ferris_Bakes.Models.ReciepeModel", b =>
                {
                    b.Property<int>("ReciepeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("ChapterId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReciepeNumber");

                    b.ToTable("Reciepes");
                });

            modelBuilder.Entity("Ferris_Bakes.Models.SetOrderModel", b =>
                {
                    b.Property<int>("BakeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BakeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BakeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FillFlavor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flavor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frosting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("BakeID");

                    b.ToTable("SetOrderList");
                });
#pragma warning restore 612, 618
        }
    }
}
