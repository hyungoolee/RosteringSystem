using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RosteringSystem.Models
{
    public class RosteringContext : DbContext
    {
        public RosteringContext() : base("AppContext")
        {
        }

        public DbSet<Customer> Customers;
        public DbSet<Customer> Jobs;
        public DbSet<Customer> Roles;
        public DbSet<Customer> Shifts;
        public DbSet<Customer> Staff;
        public DbSet<Customer> StaffShifts;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}