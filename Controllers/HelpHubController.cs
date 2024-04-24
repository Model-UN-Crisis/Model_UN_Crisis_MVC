using Microsoft.AspNetCore.Mvc;
using Model_UN_Crisis.DAL;
using Model_UN_Crisis.Models;
using System.Text.RegularExpressions;
using System.Timers;

namespace Model_UN_Crisis.Controllers
{
    public class HelpHubController : Controller
    {

        public HelpHubController()
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            try 
            {
                return View();
            } 
            catch (Exception ex)
            { 
                return View();
            }
        }
    }
}
