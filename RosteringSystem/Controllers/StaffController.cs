using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RosteringSystem.ViewModels;
using RosteringSystem.Data;
using RosteringSystem.Data.Models;

namespace RosteringSystem.Controllers
{
    public class StaffController : BaseController
    {
        // Display Staff List to the view
        //        public ActionResult Index()
        //        {
        //            StaffViewModel StaffVM = new StaffViewModel();
        //            StaffVM.RoleList = Repository.RoleList(); 
        //            StaffVM.StaffList = Repository.StaffList();
        //            return View(StaffVM);
        //        }
        //        //stafflist to update after ajax call
        //        //Add New Staff
        //        [HttpPost]
        //        public ActionResult Index(StaffViewModel PostData)
        //        {
        //            var StaffData = new Staff
        //            {
        //                FirstName = PostData.FirstName,
        //                LastName = PostData.LastName,
        //                RoleId = PostData.RoleIdSelected
        //            };
        //            Repository.CreateStaff(StaffData);
        //            return RedirectToAction("index", "Staff");
        //        }
        //        //Delete Staff
        //        public ActionResult Delete(int StaffId)
        //        {
        //            Repository.RemoveStaffById(StaffId);
        //            return RedirectToAction("index", "Staff");
        //        }
        //        //Update Staff
        //        public ActionResult Update(int StaffId)
        //        {
        //            var StaffObj = Repository.GetStaffById(StaffId);
        //           //  return Json(StaffObj, JsonRequestBehavior.AllowGet);
        //            return Json(new {ID= StaffObj.Id, FirstName = StaffObj.FirstName , LastName = StaffObj.LastName}, JsonRequestBehavior.AllowGet);
        //        }
        //        [HttpPost]
        //        public ActionResult UpdateDataBase(int StaffId, string FirstName, string LastName)
        //        {
        //            Staff StaffObj = Repository.GetStaffById(StaffId);
        //            StaffObj.FirstName = FirstName;
        //            StaffObj.LastName = LastName;
        //            Repository.UpdateStaff(StaffObj);           
        //            return Json("Successfully Updated !!!", JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //}
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetStaffList()
        {
            var staffList = Repository.StaffList();
            return Json(staffList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Delete()
        {
            return null;
        }
        public ActionResult Update()
        {
            return null;
        }

    }
}