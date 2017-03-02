using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosteringSystem.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace RosteringSystem.ViewModels
{
    public class StaffViewModel: Staff
    {
        [Display (Name = "Role")]
        public List<Role> RoleList { get; set; }
        public int RoleIdSelected { get; set; }
        public List<Staff> StaffList { get; set; }
    }
}
