using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Disciplina.Requests;
using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Handlers.Disciplina
{
    public class DeletarDisciplinaHandler : IRequestHandler<DeletarDisciplinaRequest, CommandResponse>
    {
        IDisciplinaRepository _repository;
        public DeletarDisciplinaHandler(IDisciplinaRepository repository)
        {
            _repository = repository;
        }
        public Task<CommandResponse> Handle(DeletarDisciplinaRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _repository.Deletar(request.id);

                return Task.FromResult(new CommandResponse(true, "Disciplina deletado com sucesso", request.id));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao deletar disciplina", e.Message));

            }

        }
    }
}
