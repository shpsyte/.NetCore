using Microsoft.EntityFrameworkCore;

namespace ValueObject
{

    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=aspnet-db;Integrated Security=SSPI;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {




            modelBuilder.Entity<Customer>().OwnsOne(p => p.Name)
               .Property(p => p.FirstName).HasColumnName("FirstName");

            modelBuilder.Entity<Customer>().OwnsOne(p => p.Name)
             .Property(p => p.LastName).HasColumnName("LastName");

            modelBuilder.Entity<Customer>().OwnsOne(p => p.Document)
            .Property(p => p.DocumentNumber).HasColumnName("DocumentNumber");

            modelBuilder.Entity<Customer>().OwnsOne(p => p.EmailAddress)
            .Property(p => p.Email).HasColumnName("Email");


          modelBuilder.Entity<Supplier>().OwnsOne(p => p.Name)
               .Property(p => p.FirstName).HasColumnName("FirstName");

            modelBuilder.Entity<Supplier>().OwnsOne(p => p.Name)
             .Property(p => p.LastName).HasColumnName("LastName");

            modelBuilder.Entity<Supplier>().OwnsOne(p => p.Document)
            .Property(p => p.DocumentNumber).HasColumnName("DocumentNumber");

            modelBuilder.Entity<Supplier>().OwnsOne(p => p.Email)
            .Property(p => p.Email).HasColumnName("Email");

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Customer> Customer { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

    }


}