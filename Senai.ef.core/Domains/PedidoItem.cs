using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Domains
{
    public class PedidoItem : BaseDomains
    {
        
        //relacionamento com a class pedido 

        [ForeignKey("IdPedido")]
            public Guid IdPedido { get; set; }
            public Pedido Pedido { get; set; }


        [ForeignKey("IdProduto")]
            public Guid IdProduto { get; set; }
            public Produto Produto { get; set; }

      
    }   
}
