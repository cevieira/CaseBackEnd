using CaseBackEnd.Domain.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Commands.Aluno.Requests
{
    public class DeletarAlunoRequest: IRequest<CommandResponse>
    {
        public Guid id { get; set; }
    }
}
