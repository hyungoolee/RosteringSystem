using System;

namespace RosteringSystem.Data.Models
{
    public class StaffShift
    {
        public int StaffId { get; set; }
        public int ShiftId { get; set; }
        public DateTime TimeAssigned { get; set; }

        public Staff Staff { get; set; }
        public Shift Shift { get; set; }
    }
}