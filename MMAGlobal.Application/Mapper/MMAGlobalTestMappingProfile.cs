using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMAGlobal.Application.Responses;
using MMAGlobal.Application.Commands;
using MMAGlobal.Core.Entity;


namespace MMAGlobal.Application.Mapper
{
    public class MMAGlobalTestMappingProfile : Profile
    {
        public MMAGlobalTestMappingProfile()
        {
            CreateMap<MMAGlobalTestEntity, MMAGlobalTestResponse>().ReverseMap();
            CreateMap<MMAGlobalTestEntity, CreateMMAGlobalTestCommands>().ReverseMap();
        }
    }
}
