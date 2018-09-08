using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFC.TribunalSupremo.WfoProcessos.Domain.Models;

namespace TFC.TribunalSupremo.WfoProcessos.Domain.Data
{
    public class DefaultDbContext : DbContext
    {
        public DbSet<Processo> Processos { get; set; }
        public DbSet<Proveniencia> Proveniencias { get; set; }
        public DbSet<Relator> Relatores { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<Seccao> Seccoes { get; set; }

        public DefaultDbContext()
            : base("TFC")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Processo>()
                .Map<ProcessoNovo>(x => { x.ToTable("ProcessosNovos"); });
            modelBuilder.Entity<Processo>()
                .Map<ProcessoDistribuido>(x => { x.ToTable("ProcessosDistribuidos"); });
            modelBuilder.Entity<Processo>()
                .Map<ProcessoAgendado>(x => { x.ToTable("ProcessosAgendados"); });
            modelBuilder.Entity<Processo>()
                .Map<ProcessoJulgado>(x => { x.ToTable("ProcessosJulgados"); });
        }
    }
}
