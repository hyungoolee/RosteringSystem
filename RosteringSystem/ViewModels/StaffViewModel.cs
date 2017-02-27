using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosteringSystem.Data.Models;


namespace RosteringSystem.ViewModels
{
    public class StaffViewModel: Staff
    {
        public List<Role> RoleList { get; set; }
        public int RoleIdSelected { get; set; }
    }
}
