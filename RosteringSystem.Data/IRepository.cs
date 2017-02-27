using RosteringSystem.Data.Models;
using System.Collections.Generic;

namespace RosteringSystem.Data
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

        List<Job> JobList();
        void CreateJob(Job job);
        bool UpdateJob(Job job);
        bool RemoveJobById(int id);
        Job GetJobById(int id);


        List<Role> RoleList();
        void CreateRole(Role role);
        bool UpdateRole(Role role);
        bool RemoveRoleById(int id);
        Role GetRoleById(int id);
    }
}