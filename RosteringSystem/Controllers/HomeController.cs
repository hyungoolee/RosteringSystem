using RosteringSystem.Data;
using RosteringSystem.Data.Models;
using RosteringSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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

        // @id this is the selected shift id
        [HttpPost]
        public JsonResult GetAvailStaffForShift(int id)
        {
            List<Staff> freeStaff = new List<Staff>();
            //shift conflict logic
            //get the required shift information from database associating to shiftId dropdown list
            var requiredShift = Repository.GetShiftById(id);
            if (requiredShift == null) throw new NullReferenceException();
            //get the required start and end time from corresponding shift
            var requiredStartTime = requiredShift.Start;
            var requiredEndTime = requiredShift.End;
            //get all the corresponding staff from database associated to required role 
            var staff = Repository.GetAvailStaffListForShift(id);
            //get database
            //join three tables: StaffShift/Shift/Staff
            using (var context = new RosterContext())
            {
                var StaffShiftTable = (from stf in context.Staff
                                       join ss in context.StaffShifts on stf.Id equals ss.StaffId
                                       join sft in context.Shifts on ss.ShiftId equals sft.Id
                                       orderby sft.End
                                       select new
                                       {
                                           id = stf.Id,
                                           name = stf.FirstName,
                                           startTime = sft.Start,
                                           endTime = sft.End
                                       }
                                       ).ToList();
                foreach (var person in staff)
                {
                    var StaffShiftTableById = StaffShiftTable.Where(s => s.id == person.Id).ToList();
                    //addable is the flag, if it is true, then we can add the current person to the dropdown list
                    bool addable = true;
                    foreach (var s in StaffShiftTableById)
                    {
                        //this is to check whether there is time conflict between required shift the all the shifts of the current staff
                        if (isTimeBetweenStartAndEndTime(s.startTime, s.endTime, requiredStartTime) ||
                            isTimeBetweenStartAndEndTime(s.startTime, s.endTime, requiredEndTime))
                        {
                            addable = false;
                            break;
                        }
                        //this is to check whether any shift of the current staff overlaps the required one
                        else if (requiredStartTime < s.startTime && requiredEndTime > s.endTime)
                        {
                            addable = false;
                            break;
                        }
                        // this is to check whether any shift of the current staff matches exactly the same as the required one
                        else if (requiredStartTime == s.startTime && requiredEndTime == s.endTime)
                        {
                            addable = false;
                            break;
                        }
                    }
                    if (addable)
                    {
                        // add this staff to result
                        freeStaff.Add(person);
                    }

                }
            }
            return Json(new SelectList(freeStaff, "Id", "FirstName"));
        }

        //this is the logic to check time conflict
        private bool isTimeBetweenStartAndEndTime(DateTime start, DateTime end, DateTime required)
        {
            return required > start && required < end;
        }
    }
}