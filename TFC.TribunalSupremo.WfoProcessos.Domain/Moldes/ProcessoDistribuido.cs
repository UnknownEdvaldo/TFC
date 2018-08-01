using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Moldes
{
    public class ProcessoDistribuido : Processo
    {
        public string Requerente { get; set; }
        public string Requerida { get; set; }
        public string NumeroOrdem { get; set; }
        public Especie EspecieRecurso { get; set; }
        public Guid RelatorId { get; set; }
        public Relator Relator { get; set; }
        public IList<Relator> Adjuntos { get; set; }
        public Guid ProcessoRegistadoId { get; set;}
    }

    public enum Especie
    {
        Apelacao, 
        Agravo
    }

}


