using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RosteringSystem.Data.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        [ForeignKey("Job")]
        public int? JobId { get; set; }
        public int Capacity { get; set; }
        [ForeignKey("Role")]
        public int? RoleId { get; set; }
        public int Vacancy { get; set; }

        public virtual ICollection<StaffShift> StaffShifts { get; set; }
        public Job Job { get; set; }
        public Role Role { get; set; }
    }
}