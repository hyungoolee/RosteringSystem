using RosteringSystem.Data.Models;
using RosteringSystem.ViewModels;
using System.Web.Mvc;

namespace RosteringSystem.Controllers
{
    public class RolesController : BaseController
    {
        public ActionResult Index()
        {
            var roleViewModel = new RoleViewModel
            {
                RoleList = Repository.RoleList()
            };
            return View(roleViewModel);
        }

        [HttpPost]
        public ActionResult Index(RoleViewModel role)
        {
            var newRole = new Role
            {
                Id = role.Id,
                Name = role.Name,
            };

            Repository.CreateRole(newRole);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Repository.RemoveRoleById(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var role = Repository.GetRoleById(id);
            return Json(new { id = role.Id, name = role.Name }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateDataBase(int id, string name, string address)
        {
            var role = Repository.GetRoleById(id);
            role.Name = name;
            Repository.UpdateRole(role);
            return Json("Successfully Updated !!!", JsonRequestBehavior.AllowGet);
        }
    }
}