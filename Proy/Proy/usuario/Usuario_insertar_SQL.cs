using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//referenciamos libreria de mysql
using System.Data;

namespace Proy.usuario
{
    class Usuario_insertar_SQL
    {
        //metodo para insertar usuario
        public static int Agregar(Usuario pUsuario) {
            int retorno = 0;
            MySqlCommand consulta = new MySqlCommand(string.Format("INSERT INTO usuario (usuario, password, fecha_creacion, id_privilegio) VALUES ('{0}','{1}','{2}','{3}')", pUsuario.usuario, pUsuario.password, pUsuario.fecha_creacion, pUsuario.id_privilegio), Conexion.ObtenerConexion() );
            retorno = consulta.ExecuteNonQuery();
            return retorno;
        }
        //metodo para devolver valores de privilegio al combo
        public static List<Privilegio> ObtenerPrivilegio() //metodo de tipo lista
        {
            List<Privilegio> _lista = new List<Privilegio>(); //creamos la lista

            MySqlConnection conexion = Conexion.ObtenerConexion(); //establecemos conexion

            MySqlCommand _comando = new MySqlCommand("select id_privilegio , des_privilegio from privilegio", conexion); // enviamos la consulta
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Privilegio pPrivilegio = new Privilegio();

                pPrivilegio.id_privilegio = _reader.GetInt32(0);
                pPrivilegio.des_privilegio = _reader.GetString(1);

                _lista.Add(pPrivilegio);
            }

            return _lista;
        }

       //metodo para autentificar el usuario
        public static int Autentificar(Usuario lUsuario)
        {
                    int resultado = 0; //declaramos la variable entera
                    try
                    {
                        MySqlCommand consultas = new MySqlCommand(string.Format("SELECT usuario, des_privilegio FROM usuario INNER JOIN privilegio ON usuario.id_privilegio = privilegio.id_privilegio WHERE usuario = '{0}' AND password = '{1}'", lUsuario.usuario, lUsuario.password), Conexion.ObtenerConexion()); // realizamos la consulta
                        MySqlDataAdapter consultas_ap = new MySqlDataAdapter(consultas); //puente entre dataset y mysql
                        DataTable dt = new DataTable(); // creamos data table
                        consultas_ap.Fill(dt);//ejecuta consulta
                        if (dt.Rows.Count == 1)
                        {
                             
                             if (dt.Rows[0][1].ToString() == "Admin")
                             {
                                 resultado = 3;
                             }
                             else if (dt.Rows[0][1].ToString() == "Usuario")
                             {
                                 resultado = 4;
                             }
                            
                        }
                        else {
                            resultado = 10;
                        }

                    }
                    catch { 
                    }
            return resultado;
                }
        //metodo para mostrar usuario
        public static List<Usuario> MostrarUsuario()
        {
            List<Usuario> lista_usuario = new List<Usuario>();
            MySqlCommand consulta_mostrar_usuario = new MySqlCommand(string.Format("SELECT * FROM usuario INNER JOIN privilegio ON usuario.id_privilegio = privilegio.id_privilegio"), Conexion.ObtenerConexion());
            MySqlDataReader reader_usuario = consulta_mostrar_usuario.ExecuteReader();
            while (reader_usuario.Read())
            {
                Usuario musuario = new Usuario();
                musuario.id_usuario = reader_usuario.GetInt32("id_usuario");
                musuario.usuario = reader_usuario.GetString("usuario");
                musuario.password = reader_usuario.GetString("password");
                musuario.fecha_creacion = reader_usuario.GetString("fecha_creacion");
                musuario.des_privilegio = reader_usuario.GetString("des_privilegio");
                lista_usuario.Add(musuario);
            }
            return lista_usuario;
        }
        //metodo para buscar usuario
        public static List<Usuario> BuscarUsuario(int Bid_usuario, string Busuario)
        {
            List<Usuario> lista_buscar_usuario = new List<Usuario>();
            MySqlCommand consulta_buscar_usuario = new MySqlCommand(string.Format("SELECT * FROM usuario INNER JOIN privilegio ON usuario.id_privilegio = privilegio.id_privilegio WHERE usuario.usuario ='{1}' AND usuario.id_usuario ='{0}'", Bid_usuario, Busuario), Conexion.ObtenerConexion());
            MySqlDataReader reader_buscar_usuario = consulta_buscar_usuario.ExecuteReader();

                while (reader_buscar_usuario.Read())
                {
                    Usuario busuario = new Usuario();
                    busuario.id_usuario = reader_buscar_usuario.GetInt32("id_usuario");
                    busuario.usuario = reader_buscar_usuario.GetString("usuario");
                    busuario.password = reader_buscar_usuario.GetString("password");
                    busuario.fecha_creacion = reader_buscar_usuario.GetString("fecha_creacion");
                    busuario.des_privilegio = reader_buscar_usuario.GetString("des_privilegio");
                    lista_buscar_usuario.Add(busuario);
                }
                return lista_buscar_usuario;
        }

        public static List<Usuario> ObtenerUsuario(int Oid_usuario) 
            {
                List<Usuario> lista_obtener_usuario = new List<Usuario>(); //creamos la lista

                MySqlCommand comando_obt_usuario = new MySqlCommand(string.Format("SELECT * FROM usuario INNER JOIN privilegio ON usuario.id_privilegio = privilegio.id_privilegio WHERE usuario.id_usuario ='{0}'", Oid_usuario), Conexion.ObtenerConexion()); // enviamos la consulta
                MySqlDataReader reader_obt_usuario = comando_obt_usuario.ExecuteReader();
                while (reader_obt_usuario.Read())
                {
                    Usuario ObUsuario = new Usuario();

                    ObUsuario.id_usuario = reader_obt_usuario.GetInt32("id_usuario");
                    ObUsuario.usuario = reader_obt_usuario.GetString("usuario");
                    ObUsuario.fecha_creacion = reader_obt_usuario.GetString("fecha_creacion");
                    ObUsuario.id_privilegio = reader_obt_usuario.GetInt32("id_privilegio");
                    ObUsuario.des_privilegio = reader_obt_usuario.GetString("des_privilegio");
                    lista_obtener_usuario.Add(ObUsuario);
                }

                return lista_obtener_usuario;
            
        }
      }
}
