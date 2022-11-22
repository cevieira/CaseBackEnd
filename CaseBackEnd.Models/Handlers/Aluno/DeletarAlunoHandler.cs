using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Handlers.Aluno
{
    public class DeletarAlunoHandler : IRequestHandler<DeletarAlunoRequest, CommandResponse>
    {
        IAlunoRepository _repository;
        public DeletarAlunoHandler(IAlunoRepository repository)
        {
            _repository = repository;
        }
        public Task<CommandResponse> Handle(DeletarAlunoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _repository.Deletar(request.id);

                return Task.FromResult(new CommandResponse(true, "Aluno deletado com sucesso", request.id));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao deletar aluno", e.Message));

            }

        }
    }
}
