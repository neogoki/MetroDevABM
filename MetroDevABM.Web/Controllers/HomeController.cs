using System.Web.Mvc;

namespace MetroDevABM.Web.Controllers
{
    public class HomeController : MetroDevABMControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}