using System;
using System.Collections.Generic;

namespace RosteringSystem.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int JobId { get; set; }
        public int Capacity { get; set; }
        public int RoleId { get; set; }
        public int Vacancy { get; set; }

        public ICollection<StaffShift> StaffShifts { get; set; }
        public Job Job { get; set; }
        public Role Role { get; set; }
    }
}