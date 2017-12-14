using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models {
    [Table("Project_ProjectType")]
    public class Project_ProjectType {
        [Key]
        public int Project_ProjectTypeID { get; set; }

        public int ProjectID { get; set; }

        public int ProjectTypeID { get; set; }

    }
}