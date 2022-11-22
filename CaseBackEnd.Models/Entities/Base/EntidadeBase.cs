using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace CaseBackEnd.Domain.Entities.Base
{
    public abstract class EntidadeBase
    {
        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; protected set; }
    }
}