using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Queries.NotasBoletim.Requests;
using CaseBackEnd.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Handlers.NotasBoletim
{
    public class BuscarTodasNotasBoletimsHandler : IRequestHandler<BuscarTodasNotasBoletimRequest, CommandResponse>
    {
        INotasBoletimRepository _repository;
        public BuscarTodasNotasBoletimsHandler(INotasBoletimRepository repository)
        {
            _repository = repository;
        }
        public Task<CommandResponse> Handle(BuscarTodasNotasBoletimRequest request, CancellationToken cancellationToken)
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
