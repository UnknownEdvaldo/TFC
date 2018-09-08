using System;
using System.Collections.Generic;
using System.Text;
using TFC.TribunalSupremo.WfoProcessos.Domain;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Models
{
    public class Sessao : IEntidade
    {
        public Guid SessaoId { get; set; }
        public string NomeProcesso { get; set; }
        public DateTime DataSessao { get; set; }




    }

}