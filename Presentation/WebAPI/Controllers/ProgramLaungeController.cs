using Application.Features.Commands.CreateProgramLaunge;
using Application.Features.ProgramLaunge.Commands.CreateProgramLaunge;
using Application.Features.ProgramLaunge.Commands.DeleteLanguage;
using Application.Features.ProgramLaunge.Commands.UpdateLanguage;
using Application.Features.ProgramLaunge.Dtos;
using Application.Features.ProgramLaunge.Models;
using Application.Features.ProgramLaunge.Queries.GetByIdProgramLaunge;
using Application.Features.Queries.GetListProgramLaunge;
using Core.Application.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateLanguageCommand createLanguageCommand)
        {
            CreatedLanguageDto result = await Mediator.Send(createLanguageCommand);
            return Created("", result);
        }
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListLanguageQuery getListLanguageQuery = new() { PageRequest = pageRequest };
            LanguageListModel result = await Mediator.Send(getListLanguageQuery);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdLanguageQuery getByIdLanguagedQuery)
        {
            LanguageGetByIdDto languageGetByIdDto = await Mediator.Send(getByIdLanguagedQuery);
            return Ok(languageGetByIdDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateLanguageCommand updateLanguageCommand)
        {
            UpdatedLanguageDto result = await Mediator.Send(updateLanguageCommand);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteLanguageCommand deleteLanguageCommand)
        {
            DeletedLanguageDto deletedLanguageDto = await Mediator.Send(deleteLanguageCommand);
            return Ok(deletedLanguageDto);
        }
    }
}
