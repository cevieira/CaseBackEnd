using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Queries.Boletim.Requests;
using CaseBackEnd.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Handlers.Boletim
{
    public class BuscarTodosBoletimsHandler : IRequestHandler<BuscarTodosBoletinsRequest, CommandResponse>
    {
        IBoletimRepository _repository;
        public BuscarTodosBoletimsHandler(IBoletimRepository repository)
        {
            _repository = repository;
        }
        public Task<CommandResponse> Handle(BuscarTodosBoletinsRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var boletins = _repository.BuscarTodos();

                return Task.FromResult(new CommandResponse(true, boletins));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao buscar todos os boletins", e.Message));
            }

        }
    }
}
