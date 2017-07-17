using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Datos.DAO
{
    public class SqlServerConexion
    {
        #region VARIABLES
        private string connectionString;
        private SqlCommand command;
        private static String CALL_INSERT_USUARIO_PR = "dbo.USUARIO_INSERT_PR";
        #endregion

        //public SqlServerConexion(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //    command = new SqlCommand();
        //}
        public string sqlCnn(string connectionString)
        {
            this.connectionString = connectionString;
            return connectionString;
        }


        public void setInsertUsuario(string cnn, string rut, string nombre, string apellido, DateTime fechaNac, string cinturon, DateTime fechaIngreso, string direccion)
        {
            try
            {
                
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (cmd.Connection = new SqlConnection(cnn))
                    {
                        cmd.CommandText = CALL_INSERT_USUARIO_PR;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@rut", SqlDbType.VarChar).Value = rut;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
                        cmd.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = fechaNac;
                        cmd.Parameters.Add("@cinturon", SqlDbType.VarChar).Value = cinturon;
                        cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = fechaIngreso;
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion;

                        cmd.Connection.Open();
                            SqlDataReader sqlrd = cmd.ExecuteReader();

                        cmd.Connection.Close();
                        cmd.Connection.Dispose();
                        
                    }

                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
