
using Application.Features.Commands.CreateProgramLaunge;
using Application.Features.ProgramLaunge.Dtos;
using Application.Features.ProgramLaunge.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Core.Domain.Entities;
using Application.Features.ProgramLaunge.Commands.UpdateLanguage;
using Application.Features.ProgramLaunge.Commands.DeleteLanguage;

namespace Application.Features.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Language, CreatedLanguageDto>().ReverseMap();
            CreateMap<Language, CreateLanguageCommand>().ReverseMap();

            CreateMap<Language, LanguageListDto>().ReverseMap();
            CreateMap<Language, LanguageGetByIdDto>().ReverseMap();
            CreateMap<IPaginate<Language>, LanguageListModel>().ReverseMap();

            CreateMap<Language, UpdatedLanguageDto>().ReverseMap();
            CreateMap<Language, UpdateLanguageCommand>().ReverseMap();

            CreateMap<Language, DeletedLanguageDto>().ReverseMap();
            CreateMap<Language, DeleteLanguageCommand>().ReverseMap();


        }
    }
}
