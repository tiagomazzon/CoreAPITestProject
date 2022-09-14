using Microsoft.AspNetCore.Mvc;
using Services.Services.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        public IProjectServices _projectServices;

        public ProjectController(IProjectServices projectServices)
        {
            _projectServices = projectServices;
        }

        [HttpGet("GetProjectsDevelopers")]
        public IActionResult GetProjectsDevelopers()
        {
            try
            {
                var result = _projectServices.GetProjectDevelopers();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro em GetProjectsDevelopers: {ex.Message}");
            }
        }

        [HttpGet("GetProjects")]
        public IActionResult GetProjects()
        {
            try
            {
                var result = _projectServices.GetProjects();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro em GetProjects: {ex.Message}");
            }
        }
    }
}
