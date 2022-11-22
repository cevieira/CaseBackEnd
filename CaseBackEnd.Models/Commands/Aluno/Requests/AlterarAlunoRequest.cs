using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Commands.Aluno.Requests
{
    public class AlterarAlunoRequest: IRequest<CommandResponse>
    {
        public Entities.Aluno aluno { get; set; }
    }
}
