using Product.Application.Queries.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Application.Queries.Dtos
{

    public class ProductDto
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        public double MinAmount { get; set; }
        public double MaxAmount { get; set; }
        public double MinIncome { get; set; }
        public double MaxIncome { get; set; }
        public double MinSMEDuration { get; set; }
        public bool IsActive { get; set; }
        public double? MinInitialExpenses { get; set; }
        public double? FixedInitialExpenses { get; set; }
        public double? AgreedInitialExpenses { get; set; }
        public double? WarrantyonAmountExpenses { get; set; }
        public double? AmountWarrantyonImport { get; set; }
        public double? MinimumPreliminaryExpenses { get; set; }
        public double? FixedPreliminaryExpenses { get; set; }
        public double? AgreedPreliminaryVariableExpenses { get; set; }
        public double? FixedRecurringCost { get; set; }
        public double? AgreedRecuringCost { get; set; }
        public IEnumerable<Tax> Taxes { get; set; }
        public IEnumerable<ProductConfiguration> ProductConfigurations { get; set; }
        public double TaxSpread { get; set; }
    }

    public class Tax
    {
        public string TaxName { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        public int RoundingType { get; set; }
        public int RoundingDigits { get; set; }
        public double TaxInterest { get; set; }
    }

    public class ProductConfiguration
    {
        public string ProductConfigurationName { get; set; }
        public int MinDuration { get; set; }
        public int MaxDuration { get; set; }
        public double FundProtectionCommissionLatency { get; set; }
        public double PaymentInstitutionCommission { get; set; }
        public double FundProtectionCommission { get; set; }

    }


}
