using CaseBackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Interfaces
{
    public interface IDisciplinaRepository
    {
        void Criar(Disciplina boletim);
        IEnumerable<Disciplina> BuscarTodos();
        Disciplina BuscarPorId(Guid id);
        void Atualizar(Disciplina disciplina);
        void Deletar(Guid id);
    }
}
