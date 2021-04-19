using AutoMapper;
using Core.Application.Contracts.Persistence;
using Core.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Core.Application.Commands.Loan
{
    public class CreateLoanRequestHandler : IRequestHandler<CreateLoanRequestCommand, long>
    {
        private readonly ILoanRepository _loans;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateLoanRequestHandler> _logger;

        public CreateLoanRequestHandler(IMapper mapper,
            ILoanRepository loans, ILogger<CreateLoanRequestHandler> logger)
        {
            _loans = loans ?? throw new ArgumentNullException(nameof(loans));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        public async Task<long> Handle(CreateLoanRequestCommand request, CancellationToken cancellationToken)
        {
            var dbLoan = _mapper.Map<Domain.Entities.Application>(request);
            var newApp = await _loans.AddAsync(dbLoan);

            _logger.LogInformation($"Loan {newApp.Id} is successfully created.");

            //await SendMail(newOrder);

            return newApp.Id;
        }
    }

}
