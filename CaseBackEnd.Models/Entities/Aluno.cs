using CaseBackEnd.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace CaseBackEnd.Domain.Entities
{
    public class Aluno : EntidadeBase
    {
        public Aluno(string nome, string email, DateTime data_nascimento)
        {
            this.Nome = nome;
            this.Email = email;
            this.Data_nascimento = data_nascimento;
        }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Data_nascimento { get; set; }
    }
}
