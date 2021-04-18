using Core.Api.Models;
using Core.Application.Commands.Loan;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core.Api.Controllers
{
    [Route("loan")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly IMediator mediator;

        public LoanController(IMediator mediator)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost("loanrequest", Name = "CalulcateLoanRequest")]
        //[ProducesResponseType(typeof(LoanRequest), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> CalulcateLoanRequest([FromBody] CreateLoanRequestCommand request)
        {
            var result = await mediator.Send(request);
            return new JsonResult(result);
        }
    }
}
