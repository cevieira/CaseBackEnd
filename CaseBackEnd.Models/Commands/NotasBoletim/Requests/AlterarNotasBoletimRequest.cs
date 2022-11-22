using CaseBackEnd.Domain.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Commands.NotasBoletim.Requests
{
    public class AlterarNotasBoletimRequest : IRequest<CommandResponse>
    {
        public Entities.NotasBoletim notasBoletim { get; set; }
    }
}
