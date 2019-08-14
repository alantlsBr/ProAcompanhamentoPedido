using ProAcompanhamentoPedido.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Models
{
    [Table("tb02_pedido")]
    public class Pedido
    {
        [Key]
        [Column("id")]
        public int PedidoId { get; set; }

        [Column("cliente_id")]
        public int ClienteId { get; set; }

        [Column("status")]
        public DomStatusPedido Status { get; set; }

        public Cliente Cliente { get; set; }
    }
}
