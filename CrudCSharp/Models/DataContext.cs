using Microsoft.EntityFrameworkCore;

namespace CrudCSharp.Models {
    public class DataContext:DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
