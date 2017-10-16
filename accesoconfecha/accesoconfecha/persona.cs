using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesoconfecha
{
    class persona
    {
        public string nombre { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public persona() { }
        public persona(string nombre,string fecha, string hora)
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.hora = hora;
        }


        }
}
