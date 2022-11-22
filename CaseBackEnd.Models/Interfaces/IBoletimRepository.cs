using CaseBackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Interfaces
{
    public interface IBoletimRepository
    {
        void Criar(Boletim boletim);
        IEnumerable<Boletim> BuscarTodos();
        Boletim BuscarPorId(Guid id);
        void Atualizar(Boletim boletim);
        void Deletar(Guid id);
    }
}
