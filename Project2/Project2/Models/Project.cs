using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models {
    [Table("Project")]
    public class Project {
        [Key]
        public int ProjectID { get; set; }

        public string ProjectName { get; set; }

        public string ProjectDescription { get; set; }

        public string ProjectImage { get; set; }

        public string ProjectDuration { get; set; }
    }
}