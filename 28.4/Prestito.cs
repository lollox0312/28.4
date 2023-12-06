using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4
{
    internal class Prestito
    {
        public DateTime Inizioprestito { get; set; }
        public DateTime Fineprestito { get; set; }
        public string Numero { get; set; }
        public Documento documento { get; set; }

    }
}
