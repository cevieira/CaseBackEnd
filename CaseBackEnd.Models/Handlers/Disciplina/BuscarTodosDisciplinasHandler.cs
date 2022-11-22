using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Queries.Disciplina.Requests;
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
    public class BuscarTodosDisciplinasHandler : IRequestHandler<BuscarTodasDisciplinasRequest, CommandResponse>
    {
        IDisciplinaRepository _repository;
        public BuscarTodosDisciplinasHandler(IDisciplinaRepository repository)
        {
            _repository = repository;
        }
        public Task<CommandResponse> Handle(BuscarTodasDisciplinasRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var disciplinas = _repository.BuscarTodos();

                return Task.FromResult(new CommandResponse(true, disciplinas));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao buscar todos as disciplinas", e.Message));
            }

        }
    }
}
