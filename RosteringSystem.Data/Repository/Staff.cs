using RosteringSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RosteringSystem.Data
{
    public partial class Repository
    {
        public List<Staff> StaffList() => _context.Staff.ToList();

        public void CreateStaff(Staff staff)
        {
            _context.Staff.Add(staff);
            _context.SaveChanges();
        }

        public bool UpdateStaff(Staff staff)
        {
            var found = _context.Staff.Find(staff.Id);
            if (found == null) return false;

            _context.Entry(found).CurrentValues.SetValues(staff);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveStaffById(int id)
        {
            var found = _context.Staff.Find(id);
            if (found == null) return false;

            _context.Staff.Remove(found);
            _context.SaveChanges();
            return true;
        }

        public Staff GetStaffById(int id)
        {
            return _context.Staff.Find(id);
        }

        public List<Staff> GetAvailStaffListForShift(int shiftId)
        {
            var found = _context.Shifts.Find(shiftId);
            if (found == null) throw new NullReferenceException();

            return _context.Staff.Include("StaffShifts").Where(s => s.RoleId == found.RoleId).ToList();
        }



    }
}