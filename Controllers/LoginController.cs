using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Model_UN_Crisis.DAL;
using Model_UN_Crisis.Models;

namespace Model_UN_Crisis.Controllers
{
    public class LoginController : Controller
    {
        private readonly ModelUNDbContext modelUNDbContext;

        public LoginController(ModelUNDbContext _modelUNDbContext)
        {
            this.modelUNDbContext = _modelUNDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["IncorrectLogin"] = false;
            return View();
        }

        [HttpPost]
        public IActionResult Index(STG_Users model)
        {
            try 
            {
                if (CorrectUser(model))
                {
                    return RedirectToAction("Index", "MessageHub");
                }
                else
                {
                    ViewData["IncorrectLogin"] = true;
                    return View(model);
                }
            } 
            catch (Exception ex)
            { 
                return View(model);
            }
        }

        private bool CorrectUser(STG_Users model)
        {
            try 
            {
                bool correct = false;
                var users = modelUNDbContext.STG_Users.ToList();
                foreach (var user in users)
                {
                    if (user.Cusername == model.Cusername && user.Cpassword == model.Cpassword)
                    {
                        correct = true;
                    }
                }
                return correct;
            } 
            catch (Exception ex) 
            { 
                return false;
            }
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(STG_Users model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    modelUNDbContext.STG_Users.Add(model);
                    modelUNDbContext.SaveChanges();
                    return RedirectToAction("Index", "Login");
                    
                }
                return View(model);
            } 
            catch (Exception ex) 
            {
                return View(model);
            }
        }
    }
}
