using System.Collections.Generic;
using System.Linq;

namespace RosteringSystem.Models
{
    public class Repository
    {
        public IEnumerable<Shift> GetShiftList()
        {
            using (var context = new RosterContext())
            {
                return context.Shifts.ToList();
            }
        }

        public IEnumerable<Staff> GetStaffList()
        {
            using (var context = new RosterContext())
            {
                return context.Staff.ToList();
            }
        }
    }
}