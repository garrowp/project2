using Project2.Models;
using Project2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class ProjectsController : Controller
    {
        private ProjectContext db = new ProjectContext();
        
        public static Dictionary<int, Project1> ElectronicsDictionary = new Dictionary<int, Project1>();
        public static Dictionary<int, Project1> WoodDictionary = new Dictionary<int, Project1>();

        // GET: Projects
        [Authorize]
        public ActionResult Electronics()
        {
            ProjectCategory Electronics = new ProjectCategory();
            Electronics.Projects = new List<Project>();
            int ElectronicID = db.ProjectTypes.Single(x => x.ProjectTypeDescription == "Electronics").ProjectTypeID;
            Electronics.ProjectTypeID = ElectronicID;
            List<Project_ProjectType> ElectronicsList = new List<Project_ProjectType>();
            ElectronicsList = db.Project_ProjectTypes.ToList().FindAll(x => x.ProjectTypeID == ElectronicID);
            foreach(Project_ProjectType item in ElectronicsList) {
                Project project = db.Projects.ToList().Single(x => x.ProjectID == item.ProjectID);
                Electronics.Projects.Add(project);
            }
            

            return View(Electronics);
        }

        public ActionResult Wood()
        {

            ProjectCategory Wood = new ProjectCategory();
            Wood.Projects = new List<Project>();
            int ElectronicID = db.ProjectTypes.Single(x => x.ProjectTypeDescription == "Wood").ProjectTypeID;
            Wood.ProjectTypeID = ElectronicID;
            List<Project_ProjectType> WoodList = new List<Project_ProjectType>();
            WoodList = db.Project_ProjectTypes.ToList().FindAll(x => x.ProjectTypeID == ElectronicID);
            foreach (Project_ProjectType item in WoodList) {
                Wood.Projects.Add(db.Projects.Single(x => x.ProjectID == item.ProjectID));
            }
            

            return View(Wood);
        }

        public ActionResult Project(int projectID, string type) {

            ProjectFull ProjectFull = new ProjectFull();

            ProjectFull.project = db.Projects.Single(x => x.ProjectID == projectID);
            ProjectFull.ProjectMaterials = db.ProjectMaterials.ToList().FindAll(x => x.ProjectID == projectID);
            ProjectFull.ProjectTools = db.ProjectTools.ToList().FindAll(x => x.ProjectID == projectID);
            ProjectFull.Project_ProjectTypes = db.Project_ProjectTypes.ToList().FindAll(x => x.ProjectID == projectID);

            ProjectFull.Tools = db.Tools.ToList();
            ProjectFull.Materials = db.Materials.ToList();
            ProjectFull.ProjectTypes = db.ProjectTypes.ToList();
            
            
            return View(ProjectFull);
        }
    }
}