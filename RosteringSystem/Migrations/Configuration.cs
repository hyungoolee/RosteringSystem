using RosteringSystem.Models;
using System.Collections.Generic;

namespace RosteringSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<RosteringSystem.Models.RosterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(RosteringSystem.Models.RosterContext context)
        {
            var roles = new List<Role>
            {
            new Role{Name="Software Enginner"},
            new Role{Name="Speaker"},
            new Role{Name="Soccer Player"}
            };
            roles.ForEach(s => context.Roles.AddOrUpdate(s));
            context.SaveChanges();

            var staff = new List<Staff>
            {
            new Staff{FirstName="Carson",LastName="Chan",RoleId = 1},
            new Staff{FirstName="James",LastName="Lim",RoleId = 1},
            new Staff{FirstName="Dylan",LastName="Tong",RoleId = 1},
            new Staff{FirstName="Cameo",LastName="Ahn",RoleId = 2},
            new Staff{FirstName="Mickey",LastName="Rabbitts",RoleId = 2},
            new Staff{FirstName="Young",LastName="Alexander",RoleId = 2},
            new Staff{FirstName="Hnery",LastName="Kim",RoleId = 3},
            new Staff{FirstName="Carl",LastName="Hong",RoleId = 3},
            new Staff{FirstName="Chuck",LastName="Lee",RoleId = 3}
            };

            staff.ForEach(s => context.Staff.AddOrUpdate(s));
            context.SaveChanges();

            var jobs = new List<Job>
            {
                new Job {Name = "Create a movie"},
                new Job {Name = "Clean my house"},
                new Job {Name = "Walk my puppy"},
                new Job {Name = "Do nothing"}
            };

            jobs.ForEach(s => context.Jobs.AddOrUpdate(s));
            context.SaveChanges();

            var shifts = new List<Shift>
            {
                new Shift {Capacity = 5, Vacancy = 5, Start = DateTime.Now, End = DateTime.Now, JobId = 1, RoleId = 1},
                new Shift {Capacity = 10, Vacancy = 10, Start = DateTime.Now, End = DateTime.Now, JobId = 1, RoleId = 3},
                new Shift {Capacity = 20, Vacancy = 5, Start = DateTime.Now, End = DateTime.Now, JobId = 2, RoleId = 2},
                new Shift {Capacity = 1, Vacancy = 1, Start = DateTime.Now, End = DateTime.Now, JobId = 2, RoleId = 3},
                new Shift {Capacity = 3, Vacancy = 3, Start = DateTime.Now, End = DateTime.Now, JobId = 3, RoleId = 1},
                new Shift {Capacity = 13, Vacancy = 13, Start = DateTime.Now, End = DateTime.Now, JobId = 4, RoleId = 2},
                new Shift {Capacity = 13, Vacancy = 13, Start = DateTime.Now, End = DateTime.Now, JobId = 4, RoleId = 3}
            };

            shifts.ForEach(s => context.Shifts.AddOrUpdate(s));
            context.SaveChanges();

            var staffShifts = new List<StaffShift>
            {
                new StaffShift {StaffId = 1, ShiftId = 1, TimeAssigned = DateTime.Now},
                new StaffShift {StaffId = 1, ShiftId = 2, TimeAssigned = DateTime.Now},
                new StaffShift {StaffId = 4, ShiftId = 3, TimeAssigned = DateTime.Now},
                new StaffShift {StaffId = 4, ShiftId = 1, TimeAssigned = DateTime.Now},
                new StaffShift {StaffId = 2, ShiftId = 5, TimeAssigned = DateTime.Now},
                new StaffShift {StaffId = 2, ShiftId = 6, TimeAssigned = DateTime.Now},
                new StaffShift {StaffId = 2, ShiftId = 2, TimeAssigned = DateTime.Now},
                new StaffShift {StaffId = 3, ShiftId = 2, TimeAssigned = DateTime.Now},
                new StaffShift {StaffId = 3, ShiftId = 7, TimeAssigned = DateTime.Now},
            };

            staffShifts.ForEach(s => context.StaffShifts.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}