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
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private readonly Context _context;

        public DisciplinaRepository(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<Context>();
        }

        public void Atualizar(Disciplina disciplinaAtualizada)
        {
            var disciplina = _context.Disciplinas.FirstOrDefault(x => x.Id == disciplinaAtualizada.Id);

            if (disciplina != null)
            {
                disciplina.Nome = disciplinaAtualizada.Nome;
                disciplina.Carga_horaria = disciplinaAtualizada.Carga_horaria;

                _context.SaveChanges();
            }
        }

        public Disciplina BuscarPorId(Guid id)
        {
            return _context.Disciplinas.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Disciplina> BuscarTodos()
        {
            return _context.Disciplinas.ToList();
        }

        public void Criar(Disciplina disciplina)
        {
            _context.Disciplinas.Add(disciplina);
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            var disciplina = BuscarPorId(id);

            _context.Disciplinas.Remove(disciplina);
            _context.SaveChanges();
        }
    }
}
