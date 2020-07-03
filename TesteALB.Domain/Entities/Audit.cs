using System;
using System.Collections.Generic;
using System.Text;

namespace TesteALB.Domain.Entities
{
    public class Audit
    {
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime ModificadoEm { get; set; }
        public bool Excluido { get; set; }
    }
}
