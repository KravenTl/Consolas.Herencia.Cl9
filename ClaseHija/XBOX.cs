using Clase_9_Herencia.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_Herencia.ClaseHija
{
    internal class XBOX:ClsConsola
    {
        public string gamepass { get; set; }
        public string MostrarDetallesXB()
        {
            MostrarDetalles();
            return $"Tiene gamepass? : {gamepass}";
            ;
        }
    }

}
