using Microsoft.AspNetCore.Mvc;
using Model_UN_Crisis.DAL;
using Model_UN_Crisis.Models;
using System.Text.RegularExpressions;
using System.Timers;

namespace Model_UN_Crisis.Controllers
{
    public class DirectivesHubController : Controller
    {
        private readonly ModelUNDbContext modelUNDbContext;

        public DirectivesHubController(ModelUNDbContext _modelUNDbContext)
        {
            this.modelUNDbContext = _modelUNDbContext;
        }

        [HttpGet]
        public IActionResult Index(STG_Directives model)
        {
            try 
            {
                ViewData["Users"] = modelUNDbContext.STG_Users.ToList();
                var news = modelUNDbContext.STG_Directives.ToList();
                return View(news);
            } 
            catch (Exception ex)
            { 
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult IndexDelegate(STG_Directives model)
        {
            try
            {
                ViewData["Users"] = modelUNDbContext.STG_Users.ToList();
                var news = modelUNDbContext.STG_Directives.ToList();
                return View(news);
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult CreateNews()
        {
            try
            {
                ViewData["Users"] = modelUNDbContext.STG_Users.ToList();
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult CreateNews(string messageToNews)
        {
            try
            {
                ViewData["Users"] = modelUNDbContext.STG_Users.ToList();
                var userId = HttpContext.Session.GetString("userId");
                int userIdInt = Int32.Parse(userId);
                var news = new STG_Directives
                {
                    Iauthor = userIdInt,
                    Ico_Author_1 = 0,
                    Ico_Author_2 = 0,
                    Iassigned_Staff = 0,
                    Ctext = messageToNews,
                    Cstatus = "In Review",
                    Bimage = new byte[] { 123 }
            };
                modelUNDbContext.STG_Directives.Add(news);
                modelUNDbContext.SaveChanges();
                return RedirectToAction("Index", "DirectivesHub");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "DirectivesHub");
            }
        }

        [HttpGet]
        public IActionResult ViewNews(int newsId)
        {
            try
            {
                ViewData["Users"] = modelUNDbContext.STG_Users.ToList();
                var news = modelUNDbContext.STG_Directives.ToList();
                ViewData["newsId"] = newsId;
                return View(news);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult ViewNews(STG_Directives model, int newsId)
        {
            try
            {
                ViewData["Users"] = modelUNDbContext.STG_Users.ToList();
                var news = modelUNDbContext.STG_Directives.ToList();
                ViewData["newsId"] = newsId;
                return View(news);
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult AcceptDirective(int directiveId)
        {
            try
            {
                var news = modelUNDbContext.STG_Directives.ToList();
                var updatedUser = modelUNDbContext.STG_Directives.FirstOrDefault(e => e.Idirective_Id == directiveId);
                updatedUser.Cstatus = "Accepted";
                modelUNDbContext.SaveChanges();
                return RedirectToAction("IndexDelegate", "DirectivesHub");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult DenyDirective(int directiveId)
        {
            try
            {
                var news = modelUNDbContext.STG_Directives.ToList();
                var updatedUser = modelUNDbContext.STG_Directives.FirstOrDefault(e => e.Idirective_Id == directiveId);
                updatedUser.Cstatus = "Denied";
                modelUNDbContext.SaveChanges();
                return RedirectToAction("IndexDelegate", "DirectivesHub");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
