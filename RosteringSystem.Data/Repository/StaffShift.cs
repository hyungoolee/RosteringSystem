using RosteringSystem.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace RosteringSystem.Data
{
    public partial class Repository
    {
        public void CreateStaffShift(StaffShift shift)
        {
            _context.StaffShifts.Add(shift);
            _context.SaveChanges();
        }

        public List<StaffShift> StaffShiftList() => _context.StaffShifts.ToList();

        public bool UpdateStaffShift(StaffShift staffShift)
        {
            var found = _context.StaffShifts.FirstOrDefault(s => s.StaffId == staffShift.StaffId && s.ShiftId == staffShift.ShiftId);
            if (found == null) return false;

            _context.Entry(found).CurrentValues.SetValues(staffShift);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveStaffShift(StaffShift staffShift)
        {
            var found = _context.StaffShifts.FirstOrDefault(s => s.StaffId == staffShift.StaffId && s.ShiftId == staffShift.ShiftId);
            if (found == null) return false;

            _context.StaffShifts.Remove(found);
            _context.SaveChanges();
            return true;
        }
    }
}