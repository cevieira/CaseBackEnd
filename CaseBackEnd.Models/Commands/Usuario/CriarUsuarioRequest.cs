using CaseBackEnd.Domain.Commands.Response;
using CaseBackEnd.Domain.Entities.Enum;
using MediatR;

namespace CaseBackEnd.Domain.Commands.Usuario
{
    public class CriarUsuarioRequest: IRequest<CommandResponse>
    {
        public string nome { get; set; }
        public string senha { get; set; }
        public Funcao funcao { get; set; }
    }
}
