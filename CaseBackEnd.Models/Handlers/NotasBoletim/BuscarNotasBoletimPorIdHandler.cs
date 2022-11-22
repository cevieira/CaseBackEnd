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
    public class BuscarNotasBoletimPorIdHandler : IRequestHandler<BuscarNotasBoletimPorIdRequest, CommandResponse>
    {
        INotasBoletimRepository _repository;
        public BuscarNotasBoletimPorIdHandler(INotasBoletimRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(BuscarNotasBoletimPorIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var aluno = _repository.BuscarPorId(request.id);

                return Task.FromResult(new CommandResponse(true, aluno));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao buscar as notas do boletim", e.Message));

            }

        }
    }
}
