using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ferris_Bakes.Models;
using Ferris_Bakes.Entities;

namespace Ferris_Bakes.Data
{
    public class FerrisBakesContext : DbContext
    {
        public FerrisBakesContext(DbContextOptions options) : base(options)
        {
        }

        public FerrisBakesContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredients>()
                .HasKey(i => i.ReciepeID);

            modelBuilder.Entity<Ingredients>()
                .Property(i => i.ReciepeID)
                .ValueGeneratedNever();

            modelBuilder.Entity<Chapter>()
                .HasKey(i => i.ChapterId);

            modelBuilder.Entity<Chapter>()
                .Property(i => i.ChapterId)
                .ValueGeneratedNever();
            /*
            modelBuilder.Entity<CartItemModel>()
                .HasOne<SetOrderModel>(c => c.Product)
                .WithOne()
                .HasForeignKey<CartItemModel>(c => c.ProductId
                );

            /*modelBuilder.Entity<CartItemModel>()
                .HasOne<CustomOrderModel>(c => c.CustomProduct)
                .WithOne()
                .HasForeignKey<CartItemModel>(c => c.CustomProductId
                );*/

            modelBuilder.Entity<CustomOrderModel>()
                .HasKey(i => i.CustomBakeID);

            modelBuilder.Entity<SetOrderModel>()
                .HasKey(i => i.BakeID);

            modelBuilder.Entity<DatabaseSetOrder>()
                .HasKey(i => i.DBkey);

           /* modelBuilder.Entity<DatabaseCustomOrder>()
                .HasKey(i => i.DBkey);

            modelBuilder.Entity<DatabaseCustomOrder>()
                .HasOne<CustomOrderModel>()
                .WithMany()
                .HasForeignKey(d => d.CustomOrderId);*/

        }

        public DbSet<DatabaseSetOrder> SetOrders { get; set; }
        public DbSet<CustomOrderModel> CustomOrders { get; set; }
        public DbSet<SetOrderModel> SetOrderList { get; set; }
        public DbSet<CartItemModel> Cart { get; set; }
        public DbSet<ReciepeModel> Reciepes { get; set; }
        public DbSet<ReciepeBook> ReciepeBook { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FerrisBakesContext-1;Integrated Security=True");
        }
    }
}