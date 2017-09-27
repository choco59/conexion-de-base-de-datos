using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexion.mysql
{
   public class alumno
    {
    public int id { get; set;}
    public string nombre {get; set;}
    public string apellido  { get; set;}
    public string matricula { get; set; }

    public alumno() { }
    public alumno(int id, string nombre, string apellido, string matricula) 
    {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.matricula = matricula;
    }
    }
}
