using Microsoft.AspNetCore.Mvc;
using Model_UN_Crisis.DAL;
using Model_UN_Crisis.Models;
using System.Timers;

namespace Model_UN_Crisis.Controllers
{
    public class MessageHubController : Controller
    {
        private readonly ModelUNDbContext modelUNDbContext;

        public MessageHubController(ModelUNDbContext _modelUNDbContext)
        {
            this.modelUNDbContext = _modelUNDbContext;
        }

        [HttpGet]
        public IActionResult Index(STG_Messages model)
        {
            try 
            {
                var messages = modelUNDbContext.STG_Messages.ToList();
                ViewData["Users"] = modelUNDbContext.STG_Users.ToList();
                return View(messages);
            } 
            catch (Exception ex)
            { 
                return View(model);
            }
        }
        
        public IActionResult NewChat(STG_Messages messages, STG_Users users)
        {
            try 
            { 

            } 
            catch (Exception ex) { }
            return View();
        }
		public IActionResult Chat()
		{
			return View();
		}
	}
}
