using System;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Moldes
{
    public class Utilizador
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}