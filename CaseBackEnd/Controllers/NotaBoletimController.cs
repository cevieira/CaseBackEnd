using CaseBackEnd.Domain.Commands.Disciplina.Requests;
using CaseBackEnd.Domain.Commands.NotasBoletim.Requests;
using CaseBackEnd.Domain.Queries.NotasBoletim.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace CaseBackEnd.Controllers
{
    [Route("api/notasBoletins")]
    [ApiController]
    public class NotaBoletimController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "ADM")]
        public IActionResult BuscarTodos([FromServices] IMediator mediator, [FromQuery] BuscarTodasNotasBoletimRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }

        // GET api/alunos/5
        [HttpGet("{id}")]
        [Authorize(Roles = "ADM, ALN")]
        public IActionResult BuscarPorId([FromServices] IMediator mediator,
                [FromQuery] BuscarNotasBoletimPorIdRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response.Result);
        }

        // POST api/alunos
        [HttpPost]
        [Authorize(Roles = "ADM")]
        public IActionResult Criar([FromServices] IMediator mediator,
            [FromBody] CriarNotaBoletimRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }

        // PUT api/alunos/5
        [HttpPut("{id}")]
        [Authorize(Roles = "ADM")]
        public IActionResult Alterar([FromServices] IMediator mediator,
            [FromBody] AlterarNotasBoletimRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }

        // DELETE api/alunos/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "ADM")]
        public IActionResult Deletar([FromServices] IMediator mediator,
            [FromBody] DeletarNotasBoletimRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }
    }
}
