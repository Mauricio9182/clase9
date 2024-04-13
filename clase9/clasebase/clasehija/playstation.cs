using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase9.clasebase.clasehija
{
    internal class playstation: ClsConsole
    {
        public string ModeloControlador { get; set; }
        public string MostrarDetallesPS()
        {
            mostrardetalles();
            return $"modelo de controlador: {ModeloControlador}";
        }
    }
}
