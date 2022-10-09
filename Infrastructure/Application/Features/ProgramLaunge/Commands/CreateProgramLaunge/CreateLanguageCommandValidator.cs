using Application.Features.Commands.CreateProgramLaunge;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgramLaunge.Commands.CreateProgramLaunge
{
    public class CreateLanguageCommandValidator : AbstractValidator<CreateLanguageCommand>
    {
        public CreateLanguageCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}
