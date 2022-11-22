using CaseBackEnd.Domain.Commands.Response;
using MediatR;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Net;

namespace CaseBackEnd.Domain.Commands.Aluno.Requests
{
    public class CriarAlunoRequest : IRequest<CommandResponse>
    {
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime data_nascimento { get; set; }
    }
}
