using CaseBackEnd.Domain.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Commands.NotasBoletim.Requests
{
    public class CriarNotaBoletimRequest : IRequest<CommandResponse>
    {
        public Guid idDisciplina { get; set; }
        public Guid idBoletim { get; set; }
        public double nota { get; set; }

    }
}
