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
    public class AlterarDisciplinaHandler : IRequestHandler<AlterarDisciplinaRequest, CommandResponse>
    {
        IDisciplinaRepository _repository;
        public AlterarDisciplinaHandler(IDisciplinaRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(AlterarDisciplinaRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _repository.Atualizar(request.disciplina);

                return Task.FromResult(new CommandResponse(true, "Disciplina atualizado com sucesso", request.disciplina.Id));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao atualizar disciplina", e.Message));
            }
        }
    }
}
