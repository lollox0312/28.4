using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4
{
    internal class Biblioteca
    {
        public List<Utente> utenti { get; set; }
        public List<Documento> documenti { get; set; }
        public List<Prestito> prestiti { get; set; }
    }
}
