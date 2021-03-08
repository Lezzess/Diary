using Application.Dtos;
using AutoMapper;
using Core.Entities;

namespace Application.Basis
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DiaryEntry, DiaryEntryDto>();
        }
    }
}
