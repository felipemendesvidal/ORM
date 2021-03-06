﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Interfaces
{
    interface IPedidoRepository
    {
        List<Pedido> Listar();
        List<Pedido> BuscarPorStatus(string status);
        Pedido BuscarPorId(Guid id);
        void Adicionar(Pedido pedido);
        void Editar(Guid id, Pedido pedido);
        void Remover(Guid id);
    }
}
