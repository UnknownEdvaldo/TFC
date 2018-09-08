using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Models
{
    public class ProcessoDistribuido : Processo
    {
        public string Requerente { get; set; }
        public string Requerida { get; set; }
        public int NumeroOrdem { get; set; }
        public Especie EspecieRecurso { get; set; }
        public Proveniencia Proveniencia { get; set; }
        public Relator Relator { get; set; }
        public IList<Relator> Adjuntos { get; set; }



    }

    public enum Especie
    {
        Apelacao, 
        Agravo
    }

}


