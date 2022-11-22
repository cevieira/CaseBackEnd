using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.NotasBoletim.Requests;
using CaseBackEnd.Domain.Commands.Response;
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
    public class AlterarNotasBoletimHandler : IRequestHandler<AlterarNotasBoletimRequest, CommandResponse>
    {
        INotasBoletimRepository _repository;
        public AlterarNotasBoletimHandler(INotasBoletimRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(AlterarNotasBoletimRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _repository.Atualizar(request.notasBoletim);

                return Task.FromResult(new CommandResponse(true, "Notas do boletim atualizadas com sucesso", request.notasBoletim.Id));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao atualizar as notas do boletim", e.Message));
            }
        }
    }
}
