using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Model_UN_Crisis.DAL;
using Model_UN_Crisis.Models;
using System.Text.RegularExpressions;
using System.Timers;

namespace Model_UN_Crisis.Controllers
{
    public class SettingsHubController : Controller
    {
        private readonly ModelUNDbContext modelUNDbContext;

        public SettingsHubController(ModelUNDbContext _modelUNDbContext)
        {
            this.modelUNDbContext = _modelUNDbContext;
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

        [HttpPost]
        public IActionResult Index(string username, string email, string password)
        {
            try
            {
                var userId = HttpContext.Session.GetString("userId");
                int userIdInt = Int32.Parse(userId);
                var updatedUser = modelUNDbContext.STG_Users.FirstOrDefault(e => e.Iuser_id == userIdInt);
                if (username.IsNullOrEmpty() && email.IsNullOrEmpty() && password.IsNullOrEmpty()) 
                {
                    TempData["Message"] = "Everything was empty";
                    return View();
                }
                if (username.IsNullOrEmpty() && email.IsNullOrEmpty())
                {
                    updatedUser.Cpassword = password;
                    TempData["Message"] = "Password changed successfully!";
                    modelUNDbContext.SaveChanges();
                    return View();
                }
                if (username.IsNullOrEmpty() && password.IsNullOrEmpty())
                {
                    updatedUser.Cemail = email;
                    TempData["Message"] = "Email changed successfully!";
                    modelUNDbContext.SaveChanges();
                    return View();
                }
                if (email.IsNullOrEmpty() && password.IsNullOrEmpty())
                {
                    updatedUser.Cusername = username;
                    TempData["Message"] = "Username changed successfully!";
                    modelUNDbContext.SaveChanges();
                    return View();
                }
                if (username.IsNullOrEmpty())
                {
                    updatedUser.Cemail = email;
                    updatedUser.Cpassword = password;
                    TempData["Message"] = "Email and Password changed successfully!";
                    modelUNDbContext.SaveChanges();
                    return View();
                }
                if (email.IsNullOrEmpty())
                {
                    updatedUser.Cusername = username;
                    updatedUser.Cpassword = password;
                    TempData["Message"] = "Username and Password changed successfully!";
                    modelUNDbContext.SaveChanges();
                    return View();
                }
                if (password.IsNullOrEmpty())
                {
                    updatedUser.Cusername = username;
                    updatedUser.Cemail = email;
                    TempData["Message"] = "Username and Email changed successfully!";
                    modelUNDbContext.SaveChanges();
                    return View();
                }
                else
                {
                    updatedUser.Cusername = username;
                    updatedUser.Cemail = email;
                    updatedUser.Cpassword = password;
                    TempData["Message"] = "Username and Email and Password changed successfully!";
                    modelUNDbContext.SaveChanges();
                    return View();
                }
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult DeleteAccount()
        {
            try
            {
                if (!string.IsNullOrEmpty(Request.Form["confirmed"]) && Request.Form["confirmed"] == "true")
                {
                    var username = HttpContext.Session.GetString("username");
                    var userId = HttpContext.Session.GetString("userId");
                    int userIdInt = Int32.Parse(userId);
                    var deleteId = modelUNDbContext.STG_Users.Where(e => e.Iuser_id == userIdInt);
                    modelUNDbContext.STG_Users.RemoveRange(deleteId);
                    modelUNDbContext.SaveChanges();
                    return RedirectToAction("Index", "Login");
                }
                return RedirectToAction("Index", "SettingsHub");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
