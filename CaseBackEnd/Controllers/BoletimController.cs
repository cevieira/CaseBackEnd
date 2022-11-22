using CaseBackEnd.Domain.Commands.Boletim.Requests;
using CaseBackEnd.Domain.Queries.Boletim.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace CaseBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoletimController : ControllerBase
    {
        // GET: api/boletins
        [HttpGet]
        [Authorize(Roles = "ADM")]
        public IActionResult BuscarTodos([FromServices] IMediator mediator, [FromQuery] BuscarTodosBoletinsRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }

        // GET api/alunos/5
        [HttpGet("{id}")]
        [Authorize(Roles = "ALN, ADM")]

        public IActionResult BuscarPorId([FromServices] IMediator mediator,
                [FromQuery] BuscarBoletimPorIdRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response.Result);
        }

        // POST api/alunos
        [HttpPost]
        [Authorize(Roles = "ADM")]
        public IActionResult Criar([FromServices] IMediator mediator,
            [FromBody] CriarBoletimRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }

        // PUT api/alunos/5
        [HttpPut("{id}")]
        [Authorize(Roles = "ADM")]
        public IActionResult Alterar([FromServices] IMediator mediator,
            [FromBody] AlterarBoletimRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }

        // DELETE api/alunos/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "ADM")]
        public IActionResult Deletar([FromServices] IMediator mediator,
            [FromBody] DeletarBoletimRequest command)
        {
            var response = mediator.Send(command);

            return Ok(response.Result);
        }
    }
}
