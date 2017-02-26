using RosteringSystem.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RosteringSystem.Data
{
    public class RosterContext : DbContext
    {
        public RosterContext() : base("RosterContext")
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffShift> StaffShifts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffShift>().HasKey(t => new { t.StaffId, t.ShiftId });
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}