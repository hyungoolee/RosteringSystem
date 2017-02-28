using RosteringSystem.Data.Models;

namespace RosteringSystem.Data
{
    public partial class Repository
    {
        public void CreateStaffShift(StaffShift shift)
        {
            _context.StaffShifts.Add(shift);
            _context.SaveChanges();
        }
    }
}