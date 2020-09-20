using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Domains
{
    public class Produto : BaseDomains
    {
        
        public string Nome { get; set; }
        public float preco { get; set; }


       
        
    }
}
