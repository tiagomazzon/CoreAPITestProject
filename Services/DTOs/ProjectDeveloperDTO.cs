﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class ProjectDeveloperDTO
    {
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
