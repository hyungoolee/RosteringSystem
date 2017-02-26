using RosteringSystem.Data;
using RosteringSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RosteringSystem.Controllers
{
    public class StaffController : BaseController
    {
        // GET: Staff
        public ActionResult Index()
        {        
            StaffViewModel StaffVMO = new StaffViewModel();
            StaffVMO.RoleList = Repository.GetRoleList();
            return View(StaffVMO);
        }
    }
}