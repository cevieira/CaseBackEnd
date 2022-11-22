using CaseBackEnd.Domain.Commands.Aluno.Requests;
using CaseBackEnd.Domain.Commands.Disciplina.Requests;
using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Handlers.Disciplina
{
    public class CriarDisciplinaHandler : IRequestHandler<CriarDisciplinaRequest, CommandResponse>
    {
        IDisciplinaRepository _repository;
        public CriarDisciplinaHandler(IDisciplinaRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(CriarDisciplinaRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var disciplina = new Entities.Disciplina(request.nome, request.carga_horaria);

                _repository.Criar(disciplina);

                return Task.FromResult(new CommandResponse(true, "Disciplina Criado com sucesso", disciplina));

            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao criar disciplina", e.Message));

            }
        }
    }
}
