using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Usuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CaseBackEnd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [Route("Autenticar")]
        public IActionResult Autenticar([FromServices] IMediator mediator,
        [FromBody] AutenticarUsuarioRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }
    }
}
