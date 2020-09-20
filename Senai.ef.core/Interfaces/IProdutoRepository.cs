using Senai.ef.core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Interfaces
{
    public interface IProdutoRepository
    {
        List<Produto> Listar();
        Produto BuscarPorId(Guid id);
        void Adicionar(Produto produto);
        void Edita(Produto produto);
        void Remover(Guid id);
    }
}
