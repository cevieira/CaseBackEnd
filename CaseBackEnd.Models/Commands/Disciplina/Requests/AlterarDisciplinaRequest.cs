using CaseBackEnd.Domain.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Commands.Disciplina.Requests
{
    public class AlterarDisciplinaRequest : IRequest<CommandResponse>
    {
        public Entities.Disciplina disciplina { get; set; }
    }
}
