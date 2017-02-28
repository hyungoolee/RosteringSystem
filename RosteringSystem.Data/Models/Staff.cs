using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RosteringSystem.Data.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Display (Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public Role Role { get; set; }
        public virtual ICollection<StaffShift> StaffShifts { get; set; }
    }
}