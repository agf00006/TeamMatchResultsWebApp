using Microsoft.AspNetCore.Mvc;

namespace APItest.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
