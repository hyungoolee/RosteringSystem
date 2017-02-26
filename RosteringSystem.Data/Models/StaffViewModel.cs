using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosteringSystem.Data.Models
{
    public class StaffViewModel
    {
        public Staff StaffObject { get; set; }
        public IEnumerable<Role> RoleList { get; set; }
        public int RoleSelected { get; set; }
    }
}
