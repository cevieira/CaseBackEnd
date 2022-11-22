using CaseBackEnd.Domain.Commands.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Commands.Response
{
    public class CommandResponse : ICommandResponse
    {
        public CommandResponse(bool sucesso, string mensagem, object data)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Data = data;
        }

        public CommandResponse(bool sucesso, object data)
        {
            Sucesso = sucesso;
            Data = data;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Data { get; set; }
    }
}
