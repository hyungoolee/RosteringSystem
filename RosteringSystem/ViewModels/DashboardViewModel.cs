using RosteringSystem.Data.Models;
using System.Collections.Generic;

namespace RosteringSystem.ViewModels
{
    public class DashboardViewModel : StaffShift
    {
        public IEnumerable<Shift> AvailShiftList { get; set; }
        public IEnumerable<Staff> StaffList { get; set; }
    }
}