using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Models
{
    public abstract class Processo : IEntidade
    {
        public Guid Id { get; set; }
        public Proveniencia Proveniencia { get; set; }
        public Seccao Seccao { get; set; }
    }
}
