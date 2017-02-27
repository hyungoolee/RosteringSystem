using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RosteringSystem.ViewModels;
using RosteringSystem.Data;

namespace RosteringSystem.Controllers
{
    public class StaffController : BaseController
    {
        // GET: Staff
        public ActionResult Index()
        {
            StaffViewModel StaffVM = new StaffViewModel();
            StaffVM.RoleList = Repository.RoleList();
            return View(StaffVM);
        }
    }
}