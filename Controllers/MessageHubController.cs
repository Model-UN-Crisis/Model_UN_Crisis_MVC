using Microsoft.AspNetCore.Mvc;

namespace Model_UN_Crisis.Controllers
{
    public class MessageHubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
