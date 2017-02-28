using RosteringSystem.Data;
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
        public ActionResult Index()
        {
            IRepository repo = new Repository();
            var shifts = repo.ShiftList();
            return View();
        }

        public ActionResult CreateShift()
        {
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
        public ActionResult CreateShift(ShiftClass shift) {
            IRepository repo = new Repository();
            repo.CreateShift(shift);
            return RedirectToAction("Index", "Shift");
        }
    }
}