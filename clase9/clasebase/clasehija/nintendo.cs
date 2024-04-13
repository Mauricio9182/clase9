using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase9.clasebase.clasehija
{
    internal class nintendo: ClsConsole
    {
        public bool EsPortatil { get; set; }
        public string MostrarDetallesNintendo()
        {
            
            return $"es portatil: {EsPortatil}";
        }
    }
}
    