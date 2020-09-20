using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Domains
{
    public class Pedido
    {
       [Key]
        public Guid id { get; set; }
        public string Statu { get; set; }
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Define a classe produto e gera id guid aleatorio
        /// </summary>
        public Pedido()
        {

            id = Guid.NewGuid();
        }
    }
}
