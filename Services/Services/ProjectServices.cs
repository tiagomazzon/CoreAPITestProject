using Data.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using Services.DTOs;
using Services.Extensions;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProjectServices: IProjectServices
    {
        public IProjectRepository _projectRepository;
        public IDeveloperRepository _developerRepository;
        private readonly ILogger<ProjectServices> _logger;

        public ProjectServices(IDeveloperRepository developerRepository,
                                IProjectRepository projectRepository,
                                ILogger<ProjectServices> logger)
        {
            _developerRepository = developerRepository;
            _projectRepository = projectRepository;
            _logger = logger;
        }

        public List<ProjectDeveloperDTO> GetProjectDevelopers()
        {
            var result = new List<ProjectDeveloperDTO>();

            try
            {
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro em GetProjectDevelopers: {ex.Message}");
                throw ex;
            }
        }

        public List<ProjectDTO> GetProjects()
        {
            var result = new List<ProjectDTO>();

            try
            {
                result = _projectRepository.List().ToDTO();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro em GetProjects: {ex.Message}");
                throw ex;
            }
        }
    }
}
