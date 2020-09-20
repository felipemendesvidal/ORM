using Microsoft.EntityFrameworkCore;
using Senai.ef.core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Context
{
    public class PedidoContext : DbContext
    {
        public DbSet<PedidoItem> ProdutoItem { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) _ = optionsBuilder.UseSqlServer(@"Data Source=.\LAPTOP-1VLFSC9P\SQLEXPRESS");
        }
    }
}
