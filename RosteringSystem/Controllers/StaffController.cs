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
        public ActionResult Index()
        {
            var NewObj = new StaffViewModel();
            NewObj.RoleList = Repository.RoleList();
            return View(NewObj);
           // return View();
        }
        //Posting form data to the staff
        [HttpPost]
        public ActionResult Index(Staff StaffData)
        {
            return null;
        }
        [HttpPost]
        public ActionResult AddStaff(string FirstName, string LastName, int RoleID)
        {
            var NewSaff = new Staff()
            {
                FirstName = FirstName,
                LastName = LastName,
                RoleId = RoleID
            };
            Repository.CreateStaff(NewSaff);
            return null;
        }
        public ActionResult GetStaffList()
        {
            var NewStaffObj = new StaffViewModel();
            NewStaffObj.RoleList = Repository.RoleList();
            NewStaffObj.StaffList = Repository.StaffList();
            return View(NewStaffObj);
        }
        [HttpPost]
        public ActionResult Delete(int StaffID)
        {
            Repository.RemoveStaffById(StaffID);
            return null;
        }
        public ActionResult PopUp(int StaffID)
        {
            var StaffObj = Repository.GetStaffById(StaffID);
            //create an object with some data on it to pass it to the view
            var StaffNewObj = new StaffViewModel();
            StaffNewObj.RoleList = Repository.RoleList();
            StaffNewObj.Id = StaffObj.Id;
            StaffNewObj.FirstName = StaffObj.FirstName;
            StaffNewObj.LastName = StaffObj.LastName;
            StaffNewObj.RoleId = StaffObj.RoleId;

            return View(StaffNewObj);
        }

        [HttpPost]
        public ActionResult Update(string FirstName, string LastName, int RoleID, int StaffID)
        {
            var StaffToUpdate = Repository.GetStaffById(StaffID);
            StaffToUpdate.FirstName = FirstName;
            StaffToUpdate.LastName = LastName;
            StaffToUpdate.RoleId = RoleID;
            Repository.UpdateStaff(StaffToUpdate);
            return null;
        }

    }
}