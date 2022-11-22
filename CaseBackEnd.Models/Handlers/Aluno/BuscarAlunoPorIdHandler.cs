using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Entities;
using CaseBackEnd.Domain.Queries.Aluno.Requests;
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
    public class BuscarAlunoPorIdHandler : IRequestHandler<BuscarAlunoPorIdRequest, CommandResponse>
    {
        IAlunoRepository _repository;
        public BuscarAlunoPorIdHandler(IAlunoRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(BuscarAlunoPorIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var aluno = _repository.BuscarPorId(request.id);

                return Task.FromResult(new CommandResponse(true, "", aluno));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao buscar o aluno", e.Message));

            }

        }
    }
}
