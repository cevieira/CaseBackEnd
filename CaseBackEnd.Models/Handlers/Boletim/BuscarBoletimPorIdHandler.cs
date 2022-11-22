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
    public class BuscarBoletimPorIdHandler : IRequestHandler<BuscarBoletimPorIdRequest, CommandResponse>
    {
        IAlunoRepository _repository;
        public BuscarBoletimPorIdHandler(IAlunoRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(BuscarBoletimPorIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var aluno = _repository.BuscarPorId(request.id);

                return Task.FromResult(new CommandResponse(true, aluno));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao buscar o boletim", e.Message));

            }

        }

    }
}
