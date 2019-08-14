using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProAcompanhamentoPedido.Dominio
{
    public enum DomStatusPedido
    {
        [Description("Pedido na Triagem")]
        SEPARACAO,

        [Description("Pedido no Balcão")]
        BALCAO,

        [Description("Pedido entregue ao cliente")]
        ENTREGUE

    }
}
