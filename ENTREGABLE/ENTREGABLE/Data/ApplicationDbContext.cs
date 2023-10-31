using ENTREGABLE.Models;
using Microsoft.EntityFrameworkCore;

namespace ENTREGABLE.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
   

        {
            
        }
        public DbSet<Customer> Customers { get; set;  }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
