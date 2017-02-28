using RosteringSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RosteringSystem.ViewModels
{
    public class RoleViewModel : Role
    {
        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}