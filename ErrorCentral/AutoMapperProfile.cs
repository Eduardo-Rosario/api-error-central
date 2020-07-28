using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorCentral.DTOs;
using ErrorCentral.Models;
using AutoMapper;

namespace ErrorCentral
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ErrorLog, ErrorLogDTO>().ReverseMap();
        }
    }
}
