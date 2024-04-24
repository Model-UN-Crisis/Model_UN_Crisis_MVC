using Microsoft.AspNetCore.Mvc;
using Model_UN_Crisis.DAL;
using Model_UN_Crisis.Models;
using System.Text.RegularExpressions;
using System.Timers;

namespace Model_UN_Crisis.Controllers
{
    public class NewsHubController : Controller
    {
        private readonly ModelUNDbContext modelUNDbContext;

        public NewsHubController(ModelUNDbContext _modelUNDbContext)
        {
            this.modelUNDbContext = _modelUNDbContext;
        }

        [HttpGet]
        public IActionResult Index(STG_News model)
        {
            try 
            {
                var news = modelUNDbContext.STG_News.ToList();
                return View(news);
            } 
            catch (Exception ex)
            { 
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult IndexDelegate(STG_News model)
        {
            try
            {
                var news = modelUNDbContext.STG_News.ToList();
                return View(news);
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }
    }
}
