using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Queries.Aluno.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CaseBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "ADM")]
        public IActionResult BuscarTodos([FromServices] IMediator mediator, [FromQuery] BuscarTodosAlunosRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "ALN")]
        public IActionResult BuscarPorId([FromServices] IMediator mediator,
                [FromQuery] BuscarAlunoPorIdRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response.Result);
        }

        // POST api/alunos
        [HttpPost]
        [Authorize(Roles = "ADM")]
        public IActionResult Criar([FromServices] IMediator mediator,
            [FromBody] CriarAlunoRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }

        // PUT api/alunos/5
        [HttpPut("{id}")]
        [Authorize(Roles = "ADM")]
        public IActionResult Alterar([FromServices] IMediator mediator,
            [FromBody] AlterarAlunoRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }

        // DELETE api/alunos/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "ADM")]
        public IActionResult Deletar([FromServices] IMediator mediator,
            [FromBody] DeletarAlunoRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }
    }
}
