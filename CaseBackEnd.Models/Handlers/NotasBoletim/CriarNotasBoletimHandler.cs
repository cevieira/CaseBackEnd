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
    public class CriarNotasBoletimHandler : IRequestHandler<CriarNotaBoletimRequest, CommandResponse>
    {
        INotasBoletimRepository _repository;
        public CriarNotasBoletimHandler(INotasBoletimRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(CriarNotaBoletimRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var notasBoletim = new Entities.NotasBoletim(request.idDisciplina, request.idBoletim, request.nota);

                _repository.Criar(notasBoletim);

                return Task.FromResult(new CommandResponse(true, "Notas do boletim criadas com sucesso", notasBoletim));

            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao criar as notas do boletim", e.Message));

            }
        }
    }
}
