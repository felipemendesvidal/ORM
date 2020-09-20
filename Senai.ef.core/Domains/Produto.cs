using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Domains
{
    public class Produto
    {
        [Key]
        //guid= gerador unico de indentificação, substituu=i o int generic id, é mais seguro tmb
        public Guid id { get; set; }
        public string Nome { get; set; }
        public float preco { get; set; }


        /// <summary>
        /// Define a classe produto e gera id guid aleatorio
        /// </summary>
        public Produto()
        {
           id = Guid.NewGuid();
        }
    }
}
