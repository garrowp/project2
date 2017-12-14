using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models {
    [Table("ProjectMaterial")]
    public class ProjectMaterial {
        [Key]
        public int ProjectMaterialID { get; set; }

        public int ProjectID { get; set; }

        public int MaterialID { get; set; }

        public int ProjectMaterialQuantity { get; set; }
    }
}