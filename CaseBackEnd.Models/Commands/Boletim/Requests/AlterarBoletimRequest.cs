using CaseBackEnd.Domain.Commands.Response;
using MediatR;

namespace CaseBackEnd.Domain.Commands.Boletim.Requests
{
    public class AlterarBoletimRequest : IRequest<CommandResponse>
    {
        public Entities.Boletim boletim { get; set; }
    }
}
