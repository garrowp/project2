using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    public class Project1
    {
        public Project1(int projectID, string projectType, string projectName, string projectDescription, string projectDuration) {
            ProjectID = projectID;
            ProjectType = projectType;
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            ProjectDuration = projectDuration;
        }

        public Project1(int projectID, string projectType, string projectName, string projectDescription, string projectDuration, List<string> toolsRequired, Dictionary<string, int> materialsRequired, List<string> projectImage) {
            ProjectID = projectID;
            ProjectType = projectType;
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            ProjectDuration = projectDuration;
            ToolsRequired = toolsRequired;
            MaterialsRequired = materialsRequired;
            ProjectImage = projectImage;
        }

        //Project attributes are listed below
        public int ProjectID { get; set; }
        public string ProjectType { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectDuration { get; set; }
        public List<string> ToolsRequired { get; set; }
        //string is for the material name - int is for the quantity needed of that material 
        public Dictionary<string, int> MaterialsRequired { get; set; }
        public List<string> ProjectImage { get; set; }


    }
}