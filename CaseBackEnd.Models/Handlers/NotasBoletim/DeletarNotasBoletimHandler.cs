using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Boletim.Requests;
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
    public class DeletarNotasBoletimHandler : IRequestHandler<DeletarNotasBoletimRequest, CommandResponse>
    {
        INotasBoletimRepository _repository;
        public DeletarNotasBoletimHandler(INotasBoletimRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(DeletarNotasBoletimRequest request, CancellationToken cancellationToken)
        {
            try
            {
                _repository.Deletar(request.id);

                return Task.FromResult(new CommandResponse(true, "Notas do boletim deletado com sucesso", request.id));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Notas do boletim deletado com sucesso", e.Message));
            }
        }
    }
}
