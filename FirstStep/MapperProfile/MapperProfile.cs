﻿using AutoMapper;
using FirstStep.Models;
using FirstStep.Models.DTOs;

namespace FirstStep.MapperProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ProfessionKeywordDto, ProfessionKeyword>();

            CreateMap<AddAdvertisementDto, Advertisement>();
            CreateMap<UpdateAdvertisementDto, Advertisement>();

            CreateMap<Advertisement, AdvertisementDto>()
                .ForMember(
                    des => des.field_name,
                    opt => opt.MapFrom(src => src.job_Field!.field_name));

            CreateMap<Advertisement, AdvertisementShortDto>()
                .ForMember(
                    des => des.company_id,
                    opt => opt.MapFrom(src => src.hrManager!.company_id))
                .ForMember(
                    des => des.field_name,
                    opt => opt.MapFrom(src => src.job_Field!.field_name));

            CreateMap<Advertisement, JobOfferDto>();
            
            CreateMap<Company, CompanyProfileDto>();
            
            CreateMap<AddSeekerDto, Seeker>();
            CreateMap<AddCompanyDto, Company>();
            CreateMap<AddEmployeeDto, HRManager>();
            CreateMap<AddEmployeeDto, HRAssistant>();
        }
    }
}
