using CaseBackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        void Criar(Aluno aluno);
        IEnumerable<Aluno> BuscarTodos();
        Aluno BuscarPorId(Guid id);
        void Atualizar(Aluno aluno);
        void Deletar(Guid id);
    }
}
