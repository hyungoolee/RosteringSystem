using RosteringSystem.Data;
using RosteringSystem.Data.Models;
using RosteringSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RosteringSystem.Controllers
{
    public class RoleController : BaseController
    {
        public ActionResult Index()
        {
            var roles = Repository.RoleList();
            return View();
        }
        public ActionResult CreateRole()
        {
            
            //var jobs = repo.JobList();
            var roles = Repository.RoleList();
            var roleobj = new Role();
            //var viewModel = new AddRoleView();
            var roleViewModel = new RoleViewModel();
            roleViewModel.RolesList = roles.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            
            return View(roleViewModel);
        }
        [HttpPost]
        public ActionResult CreateRole(RoleViewModel role)
        {
            var newRole = new Role();
            // map role to newRole
            Repository.CreateRole(newRole);
            return RedirectToAction("Index", "Role");
        }
    }
}