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

        public string ChatParticipant { get; set; }

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

        [HttpGet]
        public IActionResult NewChat(STG_Messages model)
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

        [HttpPost]
        public IActionResult NewChat(string username)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userId = HttpContext.Session.GetString("userId");
                    var user = modelUNDbContext.STG_Users.ToList();
                    int groupId = 0;
                    foreach (var users in user)
                    {
                        if (users.Cusername == username)
                        {
                            groupId = users.Iuser_id;
                            break;
                        }
                    }
                    var messages = new STG_Messages 
                    {
                        Iauthor = Int32.Parse(userId),
                        Igroup_Id = groupId,
                        Ctext = "A new chat has been started! Please be polite and friendly to others!",
                        Ttimestamp = DateTime.Now
                    };
                    modelUNDbContext.STG_Messages.Add(messages);
                    modelUNDbContext.SaveChanges();
                    return RedirectToAction("Index", "MessageHub");
                }
                return RedirectToAction("Index", "MessageHub");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "MessageHub");
            }
        }

        [HttpGet]
		public IActionResult Chat(STG_Messages model)
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

        [HttpPost]
        public IActionResult Chat(string username)
        {
            try
            {
                HttpContext.Session.SetString("ChatParticipant", username);
                return RedirectToAction("CurrentConversation", "MessageHub");
            }
            catch (Exception ex)
            {
                return RedirectToAction("CurrentConversation", "MessageHub");

            }
        }

        [HttpGet]
        public IActionResult CurrentConversation(STG_Messages model)
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

        [HttpPost]
        public IActionResult CurrentConversation(int chatParticipantId, string messageToParticipant)
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
