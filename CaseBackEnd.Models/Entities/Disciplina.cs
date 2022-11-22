using CaseBackEnd.Domain.Entities;
using CaseBackEnd.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Entities
{
    public  class Disciplina : EntidadeBase
    {
        public Disciplina(string nome, int carga_horaria)
        {
            this.Nome = nome;
            this.Carga_horaria = carga_horaria;
        }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Carga_horaria { get; set; }
    }
}
