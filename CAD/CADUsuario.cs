using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CAD
{
    public class CADUsuario
    {
        static string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
        static SqlConnection con = new SqlConnection(cadena);
        static SqlCommand cmd;

        public DataTable autenticarUsuario(DTOUsuario user)
        {
            cmd = new SqlCommand();
            DataTable dt;
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "prc_AutenticarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", user.Usuario);
                cmd.Parameters.AddWithValue("@contrasena", user.Clave);
                dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                // ejecuta el procedimiento y guarde los resultados de la consulta en la tabla virtual osea el datatable
                con.Open();
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception error)
            {
                dt = null;
            }
            return dt;
        }
    }
   }

