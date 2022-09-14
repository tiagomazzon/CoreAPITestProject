using Data.Repositories.Interfaces;
using Data.Interfaces.Base;
using Data.Repositories.Base;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProjectRepository: RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext context): base(context)
        {

        }
    }
}
