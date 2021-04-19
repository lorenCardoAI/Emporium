using AutoMapper;
using Core.Application.Commands.Loan;
using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateLoanRequestCommand, Core.Domain.Entities.Application>()
                .ForMember(c => c.DateCreated, opt => opt.Ignore())
                .ForMember(c => c.DateUpdated, opt => opt.Ignore())
                .ForMember(c => c.SMEId, opt => opt.MapFrom(src => 279481))
                .ForMember(c => c.Amount, opt => opt.MapFrom(src => src.RequestedAmount))
                .ForMember(c => c.Duration, opt => opt.MapFrom(src => src.LoanDuration)); 
        }
    }
}
