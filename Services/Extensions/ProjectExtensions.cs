using Domain.Entities;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Extensions
{
    public static class ProjectExtensions
    {
        public static List<ProjectDTO> ToDTO(this List<Project> model)
        {
            var list = new List<ProjectDTO>();
            foreach (var item in model)
            {
                var dto = new ProjectDTO
                {
                    ProjectId = item.Id,
                    ProjectName = item.Name,
                    ProjectDescription = item.Description
                };
                list.Add(dto);
            }
            return list;
        }
    }
}
