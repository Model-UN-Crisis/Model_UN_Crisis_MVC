using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        
        public IActionResult Index(STG_Users model)
        {
            if (IsValidUser(model))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View(model);
            }
        }

        private bool IsValidUser(STG_Users model)
        {
            bool isValid = false;
            var users = modelUNDbContext.STG_Users.ToList();
            foreach (var user in users)
            {
                if (user.Cusername == model.Cusername && user.Cpassword == model.Cpassword)
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}
