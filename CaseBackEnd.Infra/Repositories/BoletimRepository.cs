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
    public class BoletimRepository : IBoletimRepository
    {
        private readonly Context _context;

        public BoletimRepository(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<Context>();
        }

        public void Atualizar(Boletim boletimAtualizado)
        {
            var boletim = _context.Boletins.FirstOrDefault(x => x.Id == boletimAtualizado.Id);

            if (boletim != null)
            {
                boletim.Data_entrega = boletimAtualizado.Data_entrega;
                boletim.IdAluno = boletimAtualizado.IdAluno;

                _context.SaveChanges();
            }
        }

        public Boletim BuscarPorId(Guid id)
        {
            return _context.Boletins.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Boletim> BuscarTodos()
        {
            return _context.Boletins.ToList();
        }

        public void Criar(Boletim boletim)
        {
            _context.Boletins.Add(boletim);
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            var boletim = BuscarPorId(id);

            _context.Boletins.Remove(boletim);
            _context.SaveChanges();
        }
    }
}
