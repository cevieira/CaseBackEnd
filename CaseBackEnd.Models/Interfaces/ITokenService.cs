using CaseBackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Interfaces
{
    public interface ITokenService
    {
        string GerarToken(Usuario usuario);
    }
}
