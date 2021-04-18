using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Models
{
    public class LoanRequestDto
    {
        //initial input
        public double RequestedAmount { get; set; }
        public int LoanDuration { get; set; }
        public double SMEIncome { get; set; }
        public int SMEActivityDuration { get; set; }
        
        //references
        //public Product Product { get; set; }
        public int ProductId { get; set; }
        public int SMEId { get; set; }
        public int FundingType { get; set; }

        //previous output - we have already calculated them
        public double MonthlyInstallment { get; set; }
        public double InterestRate { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
    }
}
