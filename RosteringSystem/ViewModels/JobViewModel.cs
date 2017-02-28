using RosteringSystem.Data.Models;
using System.Collections.Generic;

namespace RosteringSystem.ViewModels
{
    public class JobViewModel : Job
    {
        public IEnumerable<Job> JobList { get; set; }
    }
}