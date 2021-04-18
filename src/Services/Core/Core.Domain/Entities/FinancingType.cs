using Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    public class FinancingType : EntityBase
    {
        public short FinancingTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LoanRequest> LoanRequests { get; set; }

    }
}
