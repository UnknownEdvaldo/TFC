using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Moldes
{
    public class ProcessoNovo : Processo
    {
        public DateTime DataEntrada { get; set; }
        public string NumeroProcesso { get; set; }
        public string DescricaoProcesso { get; set; }
        public Obs Observacao { get; set; }
        public DateTime DataRegisto { get; set; }
        public Guid UtilizadorId { get; set; }
        public Utilizador Utilizador { get; set; }
    }

    public enum Obs
    {
        Apenso,
        Sem_Apenso
    }
}
