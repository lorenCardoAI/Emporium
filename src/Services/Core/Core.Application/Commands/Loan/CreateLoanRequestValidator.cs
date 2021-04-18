using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.Commands.Loan
{
    public class CreateLoanRequestValidator : AbstractValidator<CreateLoanRequestCommand>
    {
        public CreateLoanRequestValidator()
        {
            RuleFor(p => p.RequestedAmount)
                .NotEmpty().WithMessage("{RequestedAmount} is required.")
                .GreaterThan(0).WithMessage("{RequestedAmount} should be greater than zero.");

            RuleFor(p => p.LoanDuration)
               .NotEmpty().WithMessage("{LoanDuration} is required.")
               .GreaterThan(0).WithMessage("{LoanDuration} should be greater than zero.");

            RuleFor(p => p.SMEId)
                 .NotEmpty().WithMessage("{SMEId} is required.")
                 .GreaterThan(0).WithMessage("{SMEId} should be greater than zero.");

            RuleFor(p => p.ProductId)
                 .NotEmpty().WithMessage("{ProductId} is required.")
                 .GreaterThan(0).WithMessage("{ProductId} should be greater than zero.");
        }
    }
}
