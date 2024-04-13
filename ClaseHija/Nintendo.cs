using Clase_9_Herencia.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_Herencia.ClaseHija
{
    internal class Nintendo:ClsConsola
    {
        public bool EsPortatil {  get; set; }
        public string MostrarDellasesNintendo()
        {
            MostrarDetalles();
            return $"Es portatil: {EsPortatil}";
        }
    }
}
