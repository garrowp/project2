using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models {
    [Table("ProjectQuestion")]
    public class ProjectQuestion {
        [Key]
        public int ProjectQuestionID { get; set; }

        public int ProjectID { get; set; }

        public int UserID { get; set; }

        [Display(Name = "Question")]
        public string Question { get; set; }

        [Display(Name = "Answer")]
        public string Answer { get; set; }
    }
}