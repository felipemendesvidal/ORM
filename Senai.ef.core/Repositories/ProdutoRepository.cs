using Senai.ef.core.Domains;
using Senai.ef.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoRepository ctx;
        public ProdutoRepository()
        {
            ctx = new ProdutoRepository();
        }
        public void Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Edita(Produto produto)
        {
            throw new NotImplementedException();
        }

        public List<Produto> Listar()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
