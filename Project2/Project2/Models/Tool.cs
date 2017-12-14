using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models {
    [Table("Tool")]
    public class Tool {
        [Key]
        public int ToolID { get; set; }

        public string ToolDescription { get; set; }
    }
}