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
    public class CriarBoletimHandler : IRequestHandler<CriarBoletimRequest, CommandResponse>
    {
        IBoletimRepository _repository;
        public CriarBoletimHandler(IBoletimRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(CriarBoletimRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var boletim = new Entities.Boletim(request.data_entrega, request.idAluno);

                _repository.Criar(boletim);

                return Task.FromResult(new CommandResponse(true, "Boletim Criado com sucesso", boletim));

            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao criar boletim", e.Message));

            }
        }
    }
}
