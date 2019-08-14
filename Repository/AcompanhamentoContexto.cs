using Microsoft.EntityFrameworkCore;
using ProAcompanhamentoPedido.Dominio;
using ProAcompanhamentoPedido.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Repository
{
    public class AcompanhamentoContexto : DbContext
    {
        public AcompanhamentoContexto(DbContextOptions<AcompanhamentoContexto> opcoes) : base(opcoes)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Schema do Banco de dados
            modelBuilder.HasDefaultSchema("public");

            //Mapeamento Relacionamento
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId);

            //Mapeamento do enum DomStatusPedido
            modelBuilder
                .Entity<Pedido>()
                .Property(p => p.Status)
                .HasConversion(
                v => v.ToString(),
                v => (DomStatusPedido)Enum.Parse(typeof(DomStatusPedido), v));

        }
    }
}
