using RosteringSystem.Models;
using System.Collections.Generic;

namespace RosteringSystem
{
    public interface IRepository
    {
        List<Staff> StaffList();
        void CreateStaff(Staff staff);
        bool UpdateStaff(Staff staff);
        bool RemoveStaffById(int id);
        Staff GetStaffById(int id);

        List<Shift> ShiftList();
        void CreateShift(Shift shift);
        bool UpdateShift(Shift shift);
        bool RemoveShiftById(int id);
        Shift GetShiftById(int id);
    }
}