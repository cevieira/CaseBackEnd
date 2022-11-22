using CaseBackEnd.Domain.Entities.Base;
using CaseBackEnd.Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseBackEnd.Domain.Entities
{
    public class Usuario: EntidadeBase
    {
        public Usuario(string nome, string senha, Funcao funcao)
        {
            Nome = nome;
            Senha = senha;
            Funcao = funcao;
        }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Funcao Funcao { get; set; }
    }
}
