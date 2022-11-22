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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context _context;

        public UsuarioRepository(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetService<Context>();
        }
        public Usuario Buscar(string nome)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Nome == nome);
        }

        public void Criar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);

            _context.SaveChanges();
        }
    }
}
