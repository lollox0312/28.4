using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4
{
    
    internal class Documento
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public string Anno { get; set; }
        public string Settore { get; set; }
        public List<Scaffale> scaffali{ get; set; }
        public string stato{ get; set; }
        public List <Autore> Autori{ get; set; }

    }
}
