using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models {
    [Table("ProjectType")]
    public class ProjectType {
        [Key]
        public int ProjectTypeID { get; set; }

        public string ProjectTypeDescription { get; set; }
    }
}