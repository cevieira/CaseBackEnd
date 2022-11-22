using CaseBackEnd.Domain.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Commands.Usuario
{
    public class AutenticarUsuarioRequest: IRequest<CommandResponse>
    {
        public string nome { get; set; }
        public string senha { get; set; }
    }
}
