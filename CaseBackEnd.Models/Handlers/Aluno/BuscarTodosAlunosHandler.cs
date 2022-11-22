using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Commands.Shared;
using CaseBackEnd.Domain.Entities;
using CaseBackEnd.Domain.Queries.Aluno.Requests;
using CaseBackEnd.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Handlers.Aluno
{
    public class BuscarTodosAlunosHandler : IRequestHandler<BuscarTodosAlunosRequest, CommandResponse>
    {
        IAlunoRepository _repository;
        public BuscarTodosAlunosHandler(IAlunoRepository repository)
        {
            _repository = repository;
        }
        public Task<CommandResponse> Handle(BuscarTodosAlunosRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var alunos = _repository.BuscarTodos();

                return Task.FromResult(new CommandResponse(true, alunos));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao buscar todos os alunos", e.Message));
            }

        }
    }
}
