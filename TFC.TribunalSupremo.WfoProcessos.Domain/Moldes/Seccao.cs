using System;
using System.Collections.Generic;
using System. Text

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Models
{
    public class Seccao : IEntidade
    {
        public Guid SeccaoId { get; set; }
        public string NomeSeccao { get; set; }

    }
}