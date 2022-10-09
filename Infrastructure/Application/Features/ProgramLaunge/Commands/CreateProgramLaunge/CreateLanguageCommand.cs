using Application.Features.ProgramLaunge.Dtos;
using Application.Features.Rules;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Entities;

namespace Application.Features.Commands.CreateProgramLaunge
{
    public partial class CreateLanguageCommand : IRequest<CreatedLanguageDto>
    {
        public string Name { get; set; }

        public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommand, CreatedLanguageDto>
        {
            private readonly ILanguageRepository _languageRepository;
            private readonly IMapper _mapper;
            private readonly LanguageBusinessRules _languageBusinessRules;

            public CreateLanguageCommandHandler(ILanguageRepository languageRepository, IMapper mapper, LanguageBusinessRules languageBusinessRules)
            {
                _languageRepository = languageRepository;
                _mapper = mapper;
                _languageBusinessRules = languageBusinessRules;
            }

            public async Task<CreatedLanguageDto> Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
            {
                await _languageBusinessRules.LanguageNameCanNotBeDuplicatedWhenInserted(request.Name);

                Language language = _mapper.Map<Language>(request);
                Language createdLanguage = await _languageRepository.AddAsync(language);
                CreatedLanguageDto createdLanguageDto = _mapper.Map<CreatedLanguageDto>(createdLanguage);
                return createdLanguageDto;
            }
        }
    }
}
