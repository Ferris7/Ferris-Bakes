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
            /*modelBuilder.Entity<ReciepeBook>()
                .HasMany(r => r.Reciepes);
            modelBuilder.Entity<ReciepeBook>()
                .HasMany(r => r.Chapters);*
            modelBuilder.Entity<ReciepeBook>()
                .HasKey(rb => rb.BookId);
            modelBuilder.Entity<ReciepeModel>()
                .HasKey(r => r.ReciepeNumber);
            modelBuilder.Entity<Chapter>()
                .HasKey(c => c.ChapterId);*/
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


        }

        public DbSet<CustomOrderModel> Order { get; set; }
        public DbSet<SetOrderModel> SetOrder { get; set; }
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