using Microsoft.EntityFrameworkCore;

namespace GlobalFilters
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=aspnet-db;Integrated Security=SSPI;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasQueryFilter(p => p.isDeleted == false);
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Customer> Customer { get; set; }


    }

    public class Customer
    {
        public int id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public bool isDeleted { get; private set; }
    }
}