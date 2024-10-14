using Microsoft.AspNetCore.Mvc;

namespace gittest.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
