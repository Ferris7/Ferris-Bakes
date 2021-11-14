using Microsoft.EntityFrameworkCore;
using Ferris_Bakes.Models;
using Ferris_Bakes.Entities;

namespace Ferris_Bakes.Data
{
    public class OrderModelContext : DbContext
    {
        public OrderModelContext()
        {
        }

        public OrderModelContext(DbContextOptions<OrderModelContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Ingredients>(
                eb =>
                {
                    eb.HasNoKey();
                }
                );
        }

        public DbSet<CustomOrderModel> Order { get; set; }
        public DbSet<SetOrderModel> SetOrder { get; set; }
        public DbSet<CartItemModel> Cart { get; set; }
        public DbSet<ReciepeModel> Reciepes { get; set; }
        public DbSet<ReciepeBook> ReciepeBook { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=orderContext-1;Integrated Security=True");
        }
    }
}