using LexiconMVC_ViewModels.Models;
using LexiconMVC_ViewModels.Models.Data;
using LexiconMVC_ViewModels.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC_ViewModels.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            CreateMessageViewModel model = new CreateMessageViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMessage(CreateMessageViewModel createMessage) 
        {
            if (ModelState.IsValid)
            {
                Message message = new Message()
                {
                    FullName = createMessage.FullName,
                    Email = createMessage.Email,
                    Subject = createMessage.Subject,
                    UsrMessage = createMessage.UsrMessage
                };
                _context.Messages.Add(message);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View("Contact");
        }


        public IActionResult About()
        {
            return View();
        }

        
    }
}
