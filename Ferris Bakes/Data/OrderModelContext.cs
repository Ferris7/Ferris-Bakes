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

        public DbSet<OrderModel> Order { get; set; }
    }
}