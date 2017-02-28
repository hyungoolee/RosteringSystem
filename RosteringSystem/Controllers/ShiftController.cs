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
    public class ShiftController : Controller
    {
        // GET: Shift
        public ActionResult Index() { 
            IRepository repo = new Repository();
            var jobs = repo.JobList();
            var roles = repo.RoleList();

            var viewModel = new AddShiftView();
            viewModel.JobsList = jobs.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            viewModel.RolesList = roles.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(AddShiftView shift) {
            IRepository repo = new Repository();
            Shift s = new Shift();
            s.Capacity = shift.Capacity;
            s.JobId = shift.JobId;
            s.RoleId = shift.RoleId;
            s.Start = shift.Start;
            s.End = shift.End;
            repo.CreateShift(shift);
            return RedirectToAction("Index", "Home");
        }
    }
}