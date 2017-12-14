using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models {
    [Table("ProjectTool")]
    public class ProjectTool {
        [Key]
        public int ProjectToolID { get; set; }

        public int ProjectID { get; set; }

        public int ToolID { get; set; }
    }
}