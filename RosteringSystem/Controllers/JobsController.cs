using RosteringSystem.Data.Models;
using RosteringSystem.ViewModels;
using System.Web.Mvc;

namespace RosteringSystem.Controllers
{
    public class JobsController : BaseController
    {
        public ActionResult Index()
        {
            var jobViewModel = new JobViewModel
            {
                JobList = Repository.JobList()
            };
            return View(jobViewModel);
        }

        [HttpPost]
        public ActionResult Index(JobViewModel job)
        {
            var newJob = new Job
            {
                Id = job.Id,
                Name = job.Name,
                Address = job.Address
            };

            Repository.CreateJob(newJob);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Repository.RemoveJobById(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var job = Repository.GetJobById(id);
            return Json(new { id = job.Id, name = job.Name, address = job.Address }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateDataBase(int id, string name, string address)
        {
            var job = Repository.GetJobById(id);
            job.Name = name;
            job.Address = address;
            Repository.UpdateJob(job);
            return Json("Successfully Updated !!!", JsonRequestBehavior.AllowGet);
        }
    }
}