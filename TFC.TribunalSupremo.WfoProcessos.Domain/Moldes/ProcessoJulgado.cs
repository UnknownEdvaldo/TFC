using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Models
{
    public class ProcessoJulgado : Processo
    {
        public string NumeroOrdem { get; set; }
        public string ParecerJuiz { get; set; }
        public string Observacao { get; set; }
    }
}
