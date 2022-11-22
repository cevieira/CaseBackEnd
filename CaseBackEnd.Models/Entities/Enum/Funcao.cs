using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Entities.Enum
{
    public enum Funcao
    {
        [Description("Administrador")]
        ADM = 1,
        [Description("Aluno")]
        ALN
    }
}
