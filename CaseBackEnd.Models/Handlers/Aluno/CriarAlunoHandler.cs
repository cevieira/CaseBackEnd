using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Entities;
using CaseBackEnd.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Handlers.Aluno
{
    public class CriarAlunoHandler : IRequestHandler<CriarAlunoRequest, CommandResponse>
    {
        IAlunoRepository _repository;
        public CriarAlunoHandler(IAlunoRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(CriarAlunoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var aluno = new Entities.Aluno(request.nome, request.email, request.data_nascimento);

                _repository.Criar(aluno);

                return Task.FromResult(new CommandResponse(true, "Aluno Criado com sucesso", aluno));

            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao criar aluno", e.Message));

            }
        }
    }
}
