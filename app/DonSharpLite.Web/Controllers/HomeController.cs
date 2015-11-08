using System.Web.Mvc;
using DonSharpLite.Domain;
using DonSharpLite.Web.Controllers.Attributes;

namespace DonSharpLite.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [RequireRole(RoleType.Administrator)]
        public ActionResult AdminPage()
        {
            return View();
        }
    }
}

//weiter mit S40 Day 5 – Develop CRUD and Data Management Capabilities