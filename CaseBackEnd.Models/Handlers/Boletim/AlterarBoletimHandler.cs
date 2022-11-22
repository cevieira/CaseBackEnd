using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Boletim.Requests;
using CaseBackEnd.Domain.Commands.Response;
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
    public class AlterarBoletimHandler : IRequestHandler<AlterarBoletimRequest, CommandResponse>
    {
        IBoletimRepository _repository;
        public AlterarBoletimHandler(IBoletimRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(AlterarBoletimRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _repository.Atualizar(request.boletim);

                return Task.FromResult(new CommandResponse(true, "Boletim atualizado com sucesso", request.boletim.Id));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao atualizar boletim", e.Message));
            }
        }
    }
}
