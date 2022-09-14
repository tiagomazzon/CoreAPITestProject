using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public interface IProjectServices
    {
        List<ProjectDTO> GetProjects();
        List<ProjectDeveloperDTO> GetProjectDevelopers();
    }
}
