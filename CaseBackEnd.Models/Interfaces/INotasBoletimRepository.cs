using CaseBackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Interfaces
{
    public interface INotasBoletimRepository
    {
        void Criar(NotasBoletim boletim);
        IEnumerable<NotasBoletim> BuscarTodos();
        NotasBoletim BuscarPorId(Guid id);
        void Atualizar(NotasBoletim notasBoletim);
        void Deletar(Guid id);
    }
}
