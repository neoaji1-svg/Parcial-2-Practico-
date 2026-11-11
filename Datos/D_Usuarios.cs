using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Datos
{
    public class D_Usuario : D_Conexion
    {
        public static E_Usuario? Login(string strUsuario, string strPassword)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand("sp_ValidarLoginHash", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("_dsUsuario", strUsuario);
                        cmd.Parameters.AddWithValue("_dsPassword", strPassword);

                        using (MySqlDataReader fReader = cmd.ExecuteReader())
                        {
                            E_Usuario? usuario = null;

                            while (fReader.Read())
                            {
                                usuario = new E_Usuario();
                                usuario.id = fReader.GetInt32("id");
                                usuario.dsId = fReader.GetString("dsId");
                                usuario.dsUsuario = fReader.GetString("dsUsuario");
                            }
                            return usuario;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Opcional: escribir ex.Message en la consola de depuración o log
                System.Diagnostics.Debug.WriteLine("Error en Login: " + ex.Message);
                return null;
            }
        }
    }
}
