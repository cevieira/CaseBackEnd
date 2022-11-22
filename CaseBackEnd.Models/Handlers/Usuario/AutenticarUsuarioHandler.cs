using CaseBackEnd.Domain.Commands.Usuario;
using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Handlers.Usuario
{
    public class AutenticarUsuarioHandler : IRequestHandler<AutenticarUsuarioRequest, CommandResponse>
    {
        IUsuarioRepository _repository;

        ITokenService _tokenService;

        public AutenticarUsuarioHandler(IUsuarioRepository repository, ITokenService tokenService)
        {
            _repository = repository;
            _tokenService = tokenService;
        }
        public Task<CommandResponse> Handle(AutenticarUsuarioRequest request, CancellationToken cancellationToken)
        {

            var usuario = _repository.Buscar(request.nome);

            if (usuario == null || !BCrypt.Net.BCrypt.Verify(request.senha, usuario.Senha)) 
            {
                return Task.FromResult(new CommandResponse(false, "Usuario ou senha estão incorretos"));
            }

            var token = _tokenService.GerarToken(usuario);

            return Task.FromResult(new CommandResponse(true, ("Usuario logado com sucesso"), token));
        }
    }
}
