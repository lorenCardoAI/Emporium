using Core.Application.Contracts.Persistence;
using Core.Domain.Entities;
using Core.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Repos
{
    public class ApplicationRepository : RepositoryBase<Domain.Entities.Application>, IApplicationRepository
    {
        public ApplicationRepository(CoreDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Domain.Entities.Application>> GetLoansBySMEID(int smeId)
        {
            var orderList = await _dbContext.Applications
                                .Where(o => o.SMEId == smeId)
                                .ToListAsync();
            return orderList;
        }
    }
}
