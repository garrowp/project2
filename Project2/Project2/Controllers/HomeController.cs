using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;
using Project2.DAL;
using System.Net;
using System.Data.Entity;

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

        [Authorize]
        public ActionResult FAQ() {
            FAQ faq = new FAQ();

            faq.Projects = db.Projects.ToList();
            faq.ProjectQuestions = db.ProjectQuestions.ToList();
            faq.Users = db.Users.ToList();

            return View(faq);
        }

        //GET
        public ActionResult Create(int projectID) {
            ViewBag.projectID = projectID;
            //ViewBag.userID = db.Users.Las();
            return View();
        }

        // POST: ProjectQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectID,Question")] ProjectQuestion projectQuestion) {
            if (ModelState.IsValid) {
                db.ProjectQuestions.Add(projectQuestion);
                db.SaveChanges();
                return RedirectToAction("FAQ");
            }

            return View(projectQuestion);
        }

        // GET: ProjectQuestions/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectQuestion projectQuestion = db.ProjectQuestions.Find(id);
            if (projectQuestion == null) {
                return HttpNotFound();
            }
            return View(projectQuestion);
        }

        // POST: ProjectQuestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectQuestionID,Answer")] ProjectQuestion projectQuestion) {
            if (ModelState.IsValid) {
                string sqlStatement = "UPDATE ProjectQuestion SET Answer = '" + projectQuestion.Answer + "' WHERE ProjectQuestion.ProjectQuestionID = '" + projectQuestion.ProjectQuestionID + "';";
                db.Database.ExecuteSqlCommand(sqlStatement);
                //db.Entry(projectQuestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("FAQ");
            }
            return View(projectQuestion);
        }

    }
}