using RosteringSystem.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace RosteringSystem.Data
{
    public partial class Repository
    {
        public List<Shift> ShiftList() => _context.Shifts.ToList();

        public List<Shift> AvailShiftList()
        {
            return _context.Shifts
                .Include("Job")
                .Include("Role")
                .Where(s => s.Vacancy > 0).ToList();
        }

        public bool DecreaseVacancyById(int id)
        {
            var found = _context.Shifts.Find(id);
            if (found == null) return false;
            if (found.Vacancy <= 0) return false;

            found.Vacancy -= 1;
            _context.Entry(found).Property("Vacancy").IsModified = true;
            _context.SaveChanges();
            return true;
        }

        public void CreateShift(Shift shift)
        {
            _context.Shifts.Add(shift);
            _context.SaveChanges();
        }

        public bool UpdateShift(Shift shift)
        {
            var found = _context.Shifts.Find(shift.Id);
            if (found == null) return false;

            _context.Entry(found).CurrentValues.SetValues(shift);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveShiftById(int id)
        {
            var found = _context.Shifts.Find(id);
            if (found == null) return false;

            _context.Shifts.Remove(found);
            _context.SaveChanges();
            return true;
        }

        public Shift GetShiftById(int id)
        {
            return _context.Shifts.Find(id);
        }
    }
}