using RosteringSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RosteringSystem.ViewModels
{
    public class AddShiftView : Shift
    {
        [Display(Name = "Jobs List")]
        public IEnumerable<SelectListItem> JobsList { get; set; }
        [Display(Name = "Roles List")]
        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}