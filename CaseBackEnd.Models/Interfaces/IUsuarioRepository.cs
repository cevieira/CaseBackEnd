using CaseBackEnd.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario Buscar(string nome);
        void Criar(Usuario usuario);
    }
}
