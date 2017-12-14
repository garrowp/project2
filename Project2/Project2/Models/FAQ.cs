using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models {
    public class FAQ {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<ProjectQuestion> ProjectQuestions { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}