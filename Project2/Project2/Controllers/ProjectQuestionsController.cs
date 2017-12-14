using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project2.DAL;
using Project2.Models;

namespace Project2.Controllers
{
    public class ProjectQuestionsController : Controller
    {
        private ProjectContext db = new ProjectContext();

        // GET: ProjectQuestions
        public ActionResult Index()
        {
            return View(db.ProjectQuestions.ToList());
        }

        // GET: ProjectQuestions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectQuestion projectQuestion = db.ProjectQuestions.Find(id);
            if (projectQuestion == null)
            {
                return HttpNotFound();
            }
            return View(projectQuestion);
        }

        // GET: ProjectQuestions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectQuestionID,ProjectID,UserID,Question,Answer")] ProjectQuestion projectQuestion)
        {
            if (ModelState.IsValid)
            {
                db.ProjectQuestions.Add(projectQuestion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectQuestion);
        }

        // GET: ProjectQuestions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectQuestion projectQuestion = db.ProjectQuestions.Find(id);
            if (projectQuestion == null)
            {
                return HttpNotFound();
            }
            return View(projectQuestion);
        }

        // POST: ProjectQuestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectQuestionID,ProjectID,UserID,Question,Answer")] ProjectQuestion projectQuestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectQuestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectQuestion);
        }

        // GET: ProjectQuestions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectQuestion projectQuestion = db.ProjectQuestions.Find(id);
            if (projectQuestion == null)
            {
                return HttpNotFound();
            }
            return View(projectQuestion);
        }

        // POST: ProjectQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProjectQuestion projectQuestion = db.ProjectQuestions.Find(id);
            db.ProjectQuestions.Remove(projectQuestion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
