using CaseBackEnd.Domain.Entities;
using CaseBackEnd.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Entities
{
    public class Boletim : EntidadeBase
    {
        public Boletim(DateTime data_entrega, Guid idAluno)
        {
            this.Data_entrega = data_entrega;
            this.IdAluno = idAluno;
        }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Data_entrega { get; set; }

        [ForeignKey("IdAluno")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid IdAluno { get; set; }
    }
}
