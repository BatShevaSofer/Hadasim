using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HMO.Common.DTO;
using HMO.Repository;
using HMO.Repository.Entities;

namespace HMO.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<CityDTO, City>().ReverseMap();//to copy every class
            CreateMap<PersonalDetailesDTO, PersonalDetailes>().ReverseMap();
            CreateMap<ProducerDTO, Producer>().ReverseMap();
            CreateMap<VaccinationDTO, Vaccination>().ReverseMap();
        }
    }
}
