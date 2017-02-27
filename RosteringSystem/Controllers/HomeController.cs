using RosteringSystem.Data.Models;
using RosteringSystem.ViewModels;
using System;
using System.Web.Mvc;

namespace RosteringSystem.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var dashboard = new DashboardViewModel
            {
                AvailShiftList = Repository.AvailShiftList(),
                StaffList = Repository.StaffList()
            };
            return View(dashboard);
        }

        [HttpPost]
        public ActionResult Index(DashboardViewModel dashboard)
        {
            var staffShift = new StaffShift
            {
                StaffId = dashboard.StaffId,
                ShiftId = dashboard.ShiftId,
                TimeAssigned = DateTime.Now
            };

            Repository.CreateStaffShift(staffShift);
            Repository.DecreaseVacancyById(staffShift.ShiftId);

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}