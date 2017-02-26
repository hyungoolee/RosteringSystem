using System.Collections.Generic;

namespace RosteringSystem.Data.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Shift> Shift { get; set; }
    }
}