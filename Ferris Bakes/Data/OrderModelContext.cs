using Microsoft.EntityFrameworkCore;
using Ferris_Bakes.Models;

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