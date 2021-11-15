using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<ReciepeBook>()
                .HasMany(r => r.Reciepes);
            modelBuilder.Entity<ReciepeBook>()
                .HasMany(r => r.Chapters);
        }

        public DbSet<CustomOrderModel> Order { get; set; }
        public DbSet<SetOrderModel> SetOrder { get; set; }
        public DbSet<CartItemModel> Cart { get; set; }
        public DbSet<ReciepeModel> Reciepes { get; set; }
        public DbSet<ReciepeBook> ReciepeBook { get; set; }
        public DbSet<ReciepeBook> Chapters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FerrisBakesContext-1;Integrated Security=True");
        }
    }
}