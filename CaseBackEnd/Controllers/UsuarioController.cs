using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Usuario;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseBackEnd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: UsuarioController
        [HttpPost]
        public IActionResult Criar([FromServices] IMediator mediator,
                                    [FromBody] CriarUsuarioRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }
    }
}
