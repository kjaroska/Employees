namespace kJaroska.Models
{
    using System.Data.Entity;

    public class EmployeeDb : DbContext
    {
        public EmployeeDb()
            : base("name=EmployeeDb")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Managers)
                .WithRequired(e => e.Manager)
                .HasForeignKey(e => e.ManagerId);
        }
    }
}