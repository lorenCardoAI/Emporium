using Core.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Persistence
{
    public class CoreDbContextSeed
    {

        public static async Task SeedAsync(CoreDbContext coreContext, ILogger<CoreDbContextSeed> logger)
        {
            if (!coreContext.FinancingTypes.Any())
            {
                coreContext.FinancingTypes.AddRange(GetPreconfiguredFinancingTypes());
                await coreContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(CoreDbContext).Name);
            }
        }

        private static IEnumerable<FinancingType> GetPreconfiguredFinancingTypes()
        {
            return new List<FinancingType>
            {
                  new FinancingType() { Name = "Bullet" }
                , new FinancingType() { Name = "Rateale" }
                , new FinancingType() { Name = "Bullet a interessi anticipati" }
                , new FinancingType() { Name = "Bullet Amazon Seller" }
                , new FinancingType() { Name = "Special Finance Farmacie" }
                , new FinancingType() { Name = "Bullet (coppia)" }
                , new FinancingType() { Name = "Rateale (coppia)" }
                , new FinancingType() { Name = "Bullet a interessi anticipati (coppia)" }
                , new FinancingType() { Name = "Rateale Farmacie" }
                , new FinancingType() { Name = "Bullet a interessi anticipati Farmacie" }
                , new FinancingType() { Name = "Rateale con preammortamento" }
            };
        }
    }
}
