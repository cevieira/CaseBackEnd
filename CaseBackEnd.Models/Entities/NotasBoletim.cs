using CaseBackEnd.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaseBackEnd.Domain.Entities
{
    public class NotasBoletim : EntidadeBase
    {
        public NotasBoletim(Guid idDisciplina, Guid idBoletim, double nota)
        {
            this.IdDisciplina = idDisciplina;
            this.IdBoletim = idBoletim;
            this.Nota = nota;
        }

        [ForeignKey("IdDisciplina")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid IdDisciplina { get; set; }

        [ForeignKey("IdBoletim")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid IdBoletim { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Nota { get; set; }
    }
}
