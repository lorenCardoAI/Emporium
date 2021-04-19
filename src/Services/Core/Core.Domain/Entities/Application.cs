using Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entities
{
    public class Application : EntityBase
    {
        //public long ApplicationId { get; set; }
        //references
        //public Product Product { get; set; }
        public int ProductId { get; set; }
        public int SMEId { get; set; }


        //initial input
        public decimal Amount { get; set; }
        public int Duration { get; set; }
        //public decimal SMEIncome { get; set; }
        //public int SMEActivityDuration { get; set; }


        //public short FinancingTypeId { get; set; }
        //public virtual FinancingType FinancingType { get; set; }

        //public bool IsBullet { get; set; }

        public int ApplicationStatusId { get; set; }
        public virtual ApplicationStatus ApplicationStatus { get; set; }


        //previous output - we have already calculated them
        //public double MonthlyInstallment { get; set; }
        //public double InterestRate { get; set; }



    }
}
