using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;
using Project2.DAL;

namespace Project2.Controllers {

    public class HomeController : Controller {
        private ProjectContext db = new ProjectContext();

        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult FAQ() {
            FAQ faq = new FAQ();

            faq.Projects = db.Projects.ToList();
            faq.ProjectQuestions = db.ProjectQuestions.ToList();
            faq.Users = db.Users.ToList();

            return View(faq);
        }

    }
}