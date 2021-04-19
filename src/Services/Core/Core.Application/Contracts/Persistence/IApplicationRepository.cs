using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Contracts.Persistence
{
    public interface IApplicationRepository : IAsyncRepository<Domain.Entities.Application>
    {
        Task<IEnumerable<Domain.Entities.Application>> GetLoansBySMEID(int smeId);
    }
}
