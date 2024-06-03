using Microsoft.AspNetCore.Mvc;

namespace Loja01.Project.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
