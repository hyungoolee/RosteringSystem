using RosteringSystem.Data.Models;
using System.Collections.Generic;

namespace RosteringSystem.ViewModels
{
    public class RoleViewModel : Role
    {
        public IEnumerable<Role> RoleList { get; set; }
    }
}