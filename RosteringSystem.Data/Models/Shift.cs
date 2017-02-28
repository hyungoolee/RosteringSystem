using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RosteringSystem.Data.Models
{
    public class Shift
    {
        [Display(Name = "Shift Id")]
        public int Id { get; set; }
        [Display(Name = "Time Start")]
        public DateTime Start { get; set; }
        [Display(Name = "Time End")]
        public DateTime End { get; set; }
        [Display(Name = "Job")]
        [ForeignKey("Job")]
        public int? JobId { get; set; }
        [Display(Name = "Resources Needed")]
        public int Capacity { get; set; }
        [ForeignKey("Role")]
        [Display(Name = "Role")]
        public int? RoleId { get; set; }
        [Display(Name = "Slot Available")]
        public int Vacancy { get; set; }

        public virtual ICollection<StaffShift> StaffShifts { get; set; }
        public Job Job { get; set; }
        public Role Role { get; set; }
    }
}