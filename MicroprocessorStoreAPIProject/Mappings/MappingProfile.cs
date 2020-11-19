using AutoMapper;
using MicroprocessorStoreAPIProject.Models;
using MicroprocessorStoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroprocessorStoreAPIProject.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Store, StoreDto>();
            CreateMap<Microprocessor, MicroprocessorDto>();
        }
    }
}
