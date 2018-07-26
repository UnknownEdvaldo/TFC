using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Moldes
{
    public class Relator
    {
        public Guid RelatorId { get; set; }
        public int NumeroJuiz { get; set; }
        public string NomeJuiz { get; set; }
    }
}