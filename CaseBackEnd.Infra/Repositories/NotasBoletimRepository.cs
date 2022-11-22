using CaseBackEnd.Domain.Entities;
using CaseBackEnd.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Infra.Repositories
{
    public class NotasBoletimRepository : INotasBoletimRepository
    {
        private readonly Context _context;

        public NotasBoletimRepository(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<Context>();
        }

        public void Atualizar(NotasBoletim notasBoletimAtualizado)
        {
            var notasBoletim = _context.NotasBoletins.FirstOrDefault(x => x.Id == notasBoletimAtualizado.Id);

            if (notasBoletim != null)
            {
                notasBoletim.IdDisciplina = notasBoletimAtualizado.IdDisciplina;
                notasBoletim.IdBoletim = notasBoletimAtualizado.IdBoletim;
                notasBoletim.Nota = notasBoletimAtualizado.Nota;

                _context.SaveChanges();
            }
        }

        public NotasBoletim BuscarPorId(Guid id)
        {
            return _context.NotasBoletins.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<NotasBoletim> BuscarTodos()
        {
            return _context.NotasBoletins.ToList();
        }

        public void Criar(NotasBoletim notasBoletim)
        {
            _context.NotasBoletins.Add(notasBoletim);
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            var notasBoletim = BuscarPorId(id);

            _context.NotasBoletins.Remove(notasBoletim);
            _context.SaveChanges();
        }
    }
}
