using System;
using System.Collections.Generic;
using System.Text;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Models
{
    public class Proveniencia : IEntidade
    {
        public Guid ProvenienciaId { get; set; }
        public string NomeProveniencia { get; set; }
    }
}