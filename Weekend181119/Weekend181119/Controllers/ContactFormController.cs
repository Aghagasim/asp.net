using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weekend181119.Data;
using Weekend181119.Models;

namespace Weekend181119.Controllers
{
    public class ContactFormController : Controller
    {
        // GET: ContactForm
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Creat(ContactFormController  contactFormController)
        {

            if (_context.Students.Any(c => c.Email == contactFormController.Email))
            {
                ModelState.AddModelError("email", "Bu e-poçt artıq mövcuddur");
            }

            if (ModelState.IsValid)
            {
                _context.Students.Add(contactFormController);
                _context.SaveChanges();

                return RedirectToAction("index");
            }

            return View(contactFormController);
        }
    }
}