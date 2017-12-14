using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Project2.Models;


namespace Project2.Models {
    public class CompleteProject {

        public Project project { get; set; }
        public IEnumerable<Material> Materials { get; set; }
        public IEnumerable<ProjectMaterial> ProjectMaterials { get; set; }
        public IEnumerable<Tool> Tools { get; set; }
        public IEnumerable<ProjectTool> ProjectTools { get; set; }
    }
}