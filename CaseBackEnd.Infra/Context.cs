using CaseBackEnd.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CaseBackEnd.Infra
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Boletim> Boletins { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<NotasBoletim> NotasBoletins { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
