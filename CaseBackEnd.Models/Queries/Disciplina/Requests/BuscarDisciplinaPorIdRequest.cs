using CaseBackEnd.Domain.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Queries.Disciplina.Requests
{
    public class BuscarDisciplinaPorIdRequest : IRequest<CommandResponse>
    {
        public Guid id { get; set; }
    }
}
