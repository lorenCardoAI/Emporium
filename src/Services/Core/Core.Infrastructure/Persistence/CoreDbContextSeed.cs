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

            if (!coreContext.ApplicationStatuses.Any())
            {
                coreContext.ApplicationStatuses.AddRange(GetPreconfiguredApplicationStatuses());
                await coreContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(CoreDbContext).Name);
            }
        }

        private static IEnumerable<ApplicationStatus> GetPreconfiguredApplicationStatuses()
        {
            return new List<ApplicationStatus>
            {
                  new ApplicationStatus() { ReferenceId=0, Name = "Taken in Charge" }
                , new ApplicationStatus() { ReferenceId=20, Name = "Formulated Offers" }
                , new ApplicationStatus() { ReferenceId=30, Name = "Selected Offer" }
                , new ApplicationStatus() { ReferenceId=31, Name = "Chosen Branch" }
                , new ApplicationStatus()  { ReferenceId=32, Name = "Certified Legal Representative" }
                , new ApplicationStatus()  { ReferenceId=33, Name = "Documentation Downloaded" }
                , new ApplicationStatus()  { ReferenceId=40, Name = "Reported to Bank" }
                , new ApplicationStatus()  { ReferenceId=45, Name = "Considered application not disbursed" }
                , new ApplicationStatus()  { ReferenceId=50, Name = "Appication approved with success" }
                , new ApplicationStatus()  { ReferenceId=60, Name = "Issued Invoice" }
                , new ApplicationStatus()  { ReferenceId=70, Name = "Concluded Application" }
                , new ApplicationStatus()  { ReferenceId=75, Name = "Canceled By User" }

                , new ApplicationStatus()  { ReferenceId=76, Name = "Start-Up Closure" }
                , new ApplicationStatus()  { ReferenceId=80, Name = "Offer Conditions Rejection Closure" }
                , new ApplicationStatus()  { ReferenceId=81, Name = "Non Target Closure" }
                , new ApplicationStatus()  { ReferenceId=82, Name = "Negative Entrepreneur Feedback Closure" }
                , new ApplicationStatus()  { ReferenceId=83, Name = "Ko Budget Closure" }
                , new ApplicationStatus()  { ReferenceId=84, Name = "Phone Contact Timeout Closure" }
                , new ApplicationStatus()  { ReferenceId=85, Name = "Ko Scoring Closure" }
                , new ApplicationStatus()  { ReferenceId=86, Name = "Low Amount Closure" }
                , new ApplicationStatus()  { ReferenceId=87, Name = "No Matching Closure" }
                , new ApplicationStatus()  { ReferenceId=88, Name = "Required purpose Closure" }
                , new ApplicationStatus()  { ReferenceId=89, Name = "Negative and Detrimental Events Closure" }
                , new ApplicationStatus()  { ReferenceId=900, Name = "Bank Refusal Closure" }
                , new ApplicationStatus()  { ReferenceId=77, Name = "Reported to a non-affiliated network" }
                , new ApplicationStatus()  { ReferenceId=871, Name = "-TBD-" }
                , new ApplicationStatus()  { ReferenceId=872, Name = "-TBD-" }
                , new ApplicationStatus()  { ReferenceId=873, Name = "-TBD-" }
                , new ApplicationStatus()  { ReferenceId=874, Name = "-TBD-" }
                , new ApplicationStatus()  { ReferenceId=875, Name = "-TBD-" }
                , new ApplicationStatus()  { ReferenceId=999, Name = "Fake Application Closure" }
                , new ApplicationStatus()  { ReferenceId=100, Name = "Approved Loan" }
                , new ApplicationStatus()  { ReferenceId=110, Name = "Disbursed Loan" }
                , new ApplicationStatus()  { ReferenceId=120, Name = "Canceled Loan" }
                , new ApplicationStatus()  { ReferenceId=130, Name = "Rejected Loan" }
                , new ApplicationStatus()  { ReferenceId=140, Name = "Timeout Loan" }
                , new ApplicationStatus()  { ReferenceId=200, Name = "Extinguished Loan" }

                , new ApplicationStatus()  { ReferenceId=300, Name = "Liquidated Loann" }
                , new ApplicationStatus()  { ReferenceId=400, Name = "Default Loan" }

            };
        }

    }
}
