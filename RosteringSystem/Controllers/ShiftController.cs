using RosteringSystem.Data;
using RosteringSystem.Data.Models;
using RosteringSystem.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace RosteringSystem.Controllers
{
    public class ShiftController : BaseController
    {
        // GET: Shift
        public ActionResult Index()
        {
            var jobs = Repository.JobList();
            var roles = Repository.RoleList();

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
        public ActionResult Index(AddShiftView shift)
        {
            Shift s = new Shift();
            s.Capacity = shift.Capacity;
            s.Vacancy = s.Capacity;
            s.JobId = shift.JobId;
            s.RoleId = shift.RoleId;
            s.Start = shift.Start;
            s.End = shift.End; 
            if (ModelState.IsValid)
            {
                Repository.CreateShift(s);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}