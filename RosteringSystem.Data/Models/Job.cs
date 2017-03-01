using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RosteringSystem.Data.Models
{
    public class Job
    {
        [DisplayName("Job ID")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Shift> Shift { get; set; }
    }
}