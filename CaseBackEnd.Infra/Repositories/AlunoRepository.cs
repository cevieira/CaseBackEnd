using CaseBackEnd.Domain.Entities;
using CaseBackEnd.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CaseBackEnd.Infra.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly Context _context;

        public AlunoRepository(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<Context>();
        }

        public void Atualizar(Aluno alunoAtualizado)
        {
            var aluno = _context.Alunos.FirstOrDefault(x => x.Id == alunoAtualizado.Id);

            if (aluno != null) 
            { 
                aluno.Nome = alunoAtualizado.Nome;
                aluno.Email = alunoAtualizado.Email;
                aluno.Data_nascimento = alunoAtualizado.Data_nascimento;

                _context.SaveChanges();
            }
        }

        public void Criar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            var aluno = BuscarPorId(id);

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
        }

        public Aluno BuscarPorId(Guid id)
        {
            return _context.Alunos.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Aluno> BuscarTodos()
        {
            return _context.Alunos.ToList();
        }
    }
}
