using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models {
    public class ProjectFull {
        public Project project { get; set; }
        public IEnumerable<ProjectType> ProjectTypes { get; set; }
        public IEnumerable<Project_ProjectType> Project_ProjectTypes { get; set; }
        public IEnumerable<Material> Materials { get; set; }
        public IEnumerable<ProjectMaterial> ProjectMaterials { get; set; }
        public IEnumerable<Tool> Tools { get; set; }
        public IEnumerable<ProjectTool> ProjectTools { get; set; }
    }
}