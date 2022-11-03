using login.Controllers;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using System;

namespace login.Data
{
    public class ConnDB
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        public async Task<List<userInfo>> ConsultaUsuarios(string tsql, List<userInfo> lista)
        {
            try
            {
                await using (conn = new SqlConnection("Data Source=.\\JLSERVER;Initial Catalog=logindse;Integrated Security=True"))
                {
                    conn.Open();
                    this.cmd = new SqlCommand(tsql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userInfo usuario = new userInfo();
                        usuario.id = reader.GetInt32(0);
                        usuario.nombre = reader.GetString(1);
                        usuario.apellido = reader.GetString(2);
                        usuario.correo = reader.GetString(3);
                        usuario.edad = reader.GetInt32(4);
                        usuario.dui = reader.GetString(5);
                        usuario.genero = reader.GetString(6);
                        usuario.id_rol = reader.GetInt32(7);
                        usuario.password = reader.GetString(8);

                        lista.Add(usuario);
                    }
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Exepcion: " + ex.ToString());
            }
            return lista;
        }

        public async Task<String[]> LogInDB(string u, string c)
        {
            String[] res = new String[2];
            try
            {
                await using (conn = new SqlConnection("Data Source=.\\JLSERVER;Initial Catalog=logindse;Integrated Security=True"))
                {
                    conn.Open();
                    Debug.WriteLine("exec iniciaSesion '" + u + "','" + c + "'");
                    this.cmd = new SqlCommand("exec iniciaSesion '"+u+"','"+c+"'", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        res.SetValue(reader.GetString(0),0);
                        res.SetValue(reader.GetInt32(1).ToString(),1);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exepcion: " + ex.ToString());
            }
            return res;
        }
    }
}
