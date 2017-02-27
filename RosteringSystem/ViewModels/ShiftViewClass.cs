using RosteringSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RosteringSystem.ViewModels
{
    public class ShiftViewClass 
    {
        public List<Shift> ShiftList { get; set; }

        public ShiftViewClass() { }
        public ShiftViewClass(List<Shift> shifts) {
            ShiftList = new List<Shift>(shifts);
        }
    }
}