using CaseBackEnd.Domain.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Commands.Boletim.Requests
{
    public class CriarBoletimRequest : IRequest<CommandResponse>
    {
        public DateTime data_entrega { get; set; }
        public Guid idAluno { get; set; }
    }
}
