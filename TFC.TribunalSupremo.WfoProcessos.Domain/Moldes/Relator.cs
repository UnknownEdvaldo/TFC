using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Moldes
{
    public class Relator
    {
        public Guid Id { get; set; }
        public int NumeroJuiz { get; set; }
        public string NomeJuiz { get; set; }
        public IList<Processo> ProcessosRelator { get; set; }
        public IList<Processo> ProcessosAjudante { get; set; }
    }
}
