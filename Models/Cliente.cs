using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Models
{
    [Table("tb01_cliente")]
    public class Cliente
    {
        [Key]
        [Column("id")]
        public int ClienteId { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [InverseProperty("cliente")]
        public List<Pedido> Pedidos { get; set; }
    }
}
