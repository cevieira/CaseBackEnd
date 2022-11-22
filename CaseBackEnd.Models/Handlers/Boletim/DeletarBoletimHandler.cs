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
    public class DeletarBoletimHandler : IRequestHandler<DeletarBoletimRequest, CommandResponse>
    {
        IBoletimRepository _repository;
        public DeletarBoletimHandler(IBoletimRepository repository)
        {
            _repository = repository;
        }
        public Task<CommandResponse> Handle(DeletarBoletimRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _repository.Deletar(request.id);

                return Task.FromResult(new CommandResponse(true, "Boletim deletado com sucesso", request.id));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao deletar boletim", e.Message));

            }

        }
    }
}
