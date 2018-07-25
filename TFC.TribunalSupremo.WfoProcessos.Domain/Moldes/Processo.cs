using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Moldes
{
    public abstract class Processo
    {
        public Guid Id { get; set; }
        public Proveniencia Proveniencia { get; set; }
        public Seccao Seccao { get; set; }
    }
}
