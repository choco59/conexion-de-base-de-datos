using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace conexion.mysql
{
    class conecting
    {
    public static MySqlConnection obtenerconexion () 
    {
        MySqlConnection conecting = new MySqlConnection("server=127.0.0.1;database=login;UID=root;psw=;");
        conecting.Open();
    return conecting;
    }
    }
}
