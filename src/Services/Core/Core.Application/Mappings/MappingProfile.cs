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
            CreateMap<CreateLoanRequestCommand, LoanRequest>()
                .ForMember(c => c.DateCreated, opt => opt.Ignore())
                .ForMember(c => c.DateUpdated, opt => opt.Ignore())
                .ForMember(c => c.SMEId, opt => opt.MapFrom(src => 279481))
                .ForMember(c => c.IsBullet, opt => opt.MapFrom(src => src.LoanDuration < 12))
                .ForMember(c => c.FinancingTypeId, opt => opt.MapFrom(src => src.LoanDuration<12 ? 1:11)); 
        }
    }
}
