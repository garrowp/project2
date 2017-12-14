using Project2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2.DAL {
    public class ProjectContext : DbContext {
        public ProjectContext()
            : base("ProjectContext") {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Project_ProjectType> Project_ProjectTypes { get; set; }
        public DbSet<ProjectMaterial> ProjectMaterials { get; set; }
        public DbSet<ProjectTool> ProjectTools { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectQuestion> ProjectQuestions { get; set; }
    }
}