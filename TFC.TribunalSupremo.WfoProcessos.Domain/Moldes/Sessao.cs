using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Moldes
{
    public class Sessao
    {
        public Guid SessaoId { get; set; }
        public string NomeProcesso { get; set; }
        public DateTime DataSessao { get; set; }




    }

    public enum Especie
    {
        Apelacao,
        Agravo

    }
}