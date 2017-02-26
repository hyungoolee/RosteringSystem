using RosteringSystem.Data;
using System.Web.Mvc;

namespace RosteringSystem.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            Repository = new Repository(new RosterContext());
        }

        public Repository Repository { get; }
    }
}