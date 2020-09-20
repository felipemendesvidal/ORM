using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Domains
{
    public class BaseDomains
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Construtor adiciona id guild
        /// </summary>
        public BaseDomains()
        {
            Id = Guid.NewGuid();
        }
    }
}
