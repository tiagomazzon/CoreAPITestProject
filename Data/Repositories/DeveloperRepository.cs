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
    public class DeveloperRepository: RepositoryBase<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(ApplicationDbContext context): base(context)
        {

        }
    }
}
