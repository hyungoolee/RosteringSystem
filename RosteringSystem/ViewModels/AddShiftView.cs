using RosteringSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RosteringSystem.ViewModels
{
    public class AddShiftView : Shift
    {
        public IEnumerable<SelectListItem> JobsList { get; set; }
        public IEnumerable<SelectListItem> RolesList { get; set; }
        
    }
}