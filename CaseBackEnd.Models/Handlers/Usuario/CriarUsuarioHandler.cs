using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Commands.Usuario;
using CaseBackEnd.Domain.Entities;
using CaseBackEnd.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Handlers.Usuario
{
    public class CriarUsuarioHandler : IRequestHandler<CriarUsuarioRequest, CommandResponse>
    {
        IUsuarioRepository _repository;
        public CriarUsuarioHandler(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Task<CommandResponse> Handle(CriarUsuarioRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var hashSenha = BCrypt.Net.BCrypt.HashPassword(request.senha);

                var usuario = new Entities.Usuario(request.nome, hashSenha, request.funcao);

                _repository.Criar(usuario);

                return Task.FromResult(new CommandResponse(true, "Usuário criado com sucesso", usuario.Id));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CommandResponse(false, "Erro ao criar o usuário", e.Message));

            }



        }
    }
}
