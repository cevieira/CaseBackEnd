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
    public class AlterarAlunoHandler : IRequestHandler<AlterarAlunoRequest, CommandResponse>
    {
        IAlunoRepository _repository;
        public AlterarAlunoHandler(IAlunoRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(AlterarAlunoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _repository.Atualizar(request.aluno);

                return Task.FromResult(new CommandResponse(true, "Aluno atualizado com sucesso", request.aluno.Id));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao atualizar aluno", e.Message));
            }
        }
    }
}
