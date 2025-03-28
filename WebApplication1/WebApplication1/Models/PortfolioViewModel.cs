namespace WebApplication1.Models;
using System.Collections.Generic;

    public class PortfolioViewModel
    {
        public string Name { get; set; }
         public string Description { get; set; }
        public List<Project> Projects { get; set; }
        public List<Skill> Skills { get; set; }
    }

