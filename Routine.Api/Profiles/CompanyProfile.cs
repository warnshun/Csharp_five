﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Routine.Api.Entities;
using Routine.Api.Models;

namespace Routine.Api.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(
                    dest => dest.CompanyName,
                    options => 
                        options.MapFrom(source => source.Name));

            CreateMap<CompanyAddDto, Company>();
        }
    }
}
