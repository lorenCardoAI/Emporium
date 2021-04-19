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
    public class LoanRepository : RepositoryBase<Domain.Entities.Application>, ILoanRepository
    {
        public LoanRepository(CoreDbContext dbContext) : base(dbContext)
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
