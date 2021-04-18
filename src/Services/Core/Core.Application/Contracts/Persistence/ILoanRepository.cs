using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Contracts.Persistence
{
    public interface ILoanRepository : IAsyncRepository<LoanRequest>
    {
        Task<IEnumerable<LoanRequest>> GetLoansBySMEID(int smeId);
    }
}
