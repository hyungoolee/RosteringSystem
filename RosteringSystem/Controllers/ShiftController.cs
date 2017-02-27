using RosteringSystem.Data;
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
            var jobs = repo.ShiftList();
            return View();
        }
    }
}