using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesoconfecha
{
    class metodo_persona
    {
        public static string ObtenerFicha(persona NuevaPersona)
        {
            //metodo de tipo string (recibimos el objeto)
            string DatosFicha = "El usuario" + "  " + NuevaPersona.nombre+ " Ingresó " + " En la fecha  " + NuevaPersona.fecha + " A las  " + NuevaPersona.hora + " ";
            //almacenamos en un string los elementos del objeto
            return DatosFicha; //retornamos el string ante su invocacion
        }
    }
}
