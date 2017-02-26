using System.Collections.Generic;

namespace RosteringSystem.Data.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}