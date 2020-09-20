using Senai.ef.core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Interfaces
{
    interface IProdutoItemRepository
    {
        /// <summary>
        /// Lista todos os pedidos
        /// </summary>
        /// <returns>Retorna uma lista de pedidos</returns>
        List<Pedido> Listar();

        /// <summary>
        /// Adiciona um novo pedido
        /// </summary>
        /// <returns>Objeto Pedido</returns>
        Pedido Adicionar(List<ProdutoItem> produtoItens);
    }
}
