using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace conexion.mysql
{
    public class funciones
    {
        public static int agregar(alumno add) {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into login(nombre,apellido,matricula)values('{0}','{1}','{2}')",add.nombre,add.apellido,add.matricula),conecting.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        }
}
