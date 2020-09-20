using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Domains
{
    public class Pedido : BaseDomains
    {
      
        public string Statu { get; set; }
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Define a classe produto e gera id guid aleatorio
        /// </summary>
        
    }
}
