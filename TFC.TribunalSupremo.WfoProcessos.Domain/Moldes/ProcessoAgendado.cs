using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Moldes
{
    public class ProcessoAgendado : Processo
    {
        public string NumeroOrdem { get; set; }
        public Guid SessaoId { get; set; }
        public Sessao Sessao { get; set; }
        public DateTime DataRegisto { get; set; }

    }
}
