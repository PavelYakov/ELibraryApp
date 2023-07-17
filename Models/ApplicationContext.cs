using Microsoft.EntityFrameworkCore;

namespace TesteLibraryApp.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Division> Divisions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Division)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DivisionID);

        }
    }
}
