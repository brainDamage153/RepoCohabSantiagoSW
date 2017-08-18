using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Datos.DTO;

namespace Datos.DAO
{
    public class SqlServerConexion
    {
        #region VARIABLES
        private string connectionString;
        private SqlCommand command;
        private static String CALL_INSERT_USUARIO_PR = "dbo.USUARIO_INSERT_PR";
        private static String CALL_SELECT_USUARIO_PR = "dbo.SELECT_USUARIO_PR";
        private static String CALL_INSERT_TRABAJADOR_PR = "dbo.TRABAJADOR_INSERT_PR";
        #endregion

        #region INSTANCIAS DTO
        Luchador l = new Luchador();
        Trabajador tr = new Trabajador();
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

        public void setInsertUsuario(string cnn, Luchador l)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (cmd.Connection = new SqlConnection(cnn))
                    {
                        cmd.CommandText = CALL_INSERT_USUARIO_PR;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@rut", SqlDbType.VarChar).Value =l.Rut ;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = l.Nombre;
                        cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = l.Apellido;
                        cmd.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = l.FechaNac;
                        cmd.Parameters.Add("@cinturon", SqlDbType.VarChar).Value = l.Cinturon;
                        cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = l.FechaIngreso;
                        cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = l.Direccion;
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

        public void setInsertTrabajador(string cnn, Trabajador t)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (cmd.Connection= new SqlConnection(cnn))
                    {
                        cmd.CommandText = CALL_INSERT_TRABAJADOR_PR;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@RUT", SqlDbType.VarChar).Value=t.Rut;
                        cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = t.Nombre;
                        cmd.Parameters.Add("@APELLIDO", SqlDbType.VarChar).Value = t.Apellido;
                        cmd.Parameters.Add("@FECHA_NAC", SqlDbType.Date).Value = t.FechaNac;
                        cmd.Parameters.Add("@FECHA_INGRESO", SqlDbType.Date).Value = t.FechaIngreso;
                        cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = t.Direccion;
                        cmd.Connection.Open();
                        SqlDataReader sqlr = cmd.ExecuteReader();
                        cmd.Connection.Close();
                        cmd.Connection.Dispose();
                    }
                }
            }
            catch(Exception e)
            {

            }
        }

        //public void getLuchador(string cnn, string rut)
        //{
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            using (cmd.Connection = new SqlConnection(cnn))
        //            {
        //                cmd.CommandText = CALL_SELECT_USUARIO_PR;
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add("@RUT", SqlDbType.VarChar).Value = rut;
        //                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@APELLIDO", SqlDbType.VarChar).Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@FECHA_NAC", SqlDbType.Date).Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@FECHA_INGRESO", SqlDbType.Date).Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Direction = ParameterDirection.Output;
        //                cmd.Connection.Open();
        //                cmd.ExecuteNonQuery();
        //                l.Nombre = cmd.Parameters["@NOMBRE"].Value.ToString();
        //                l.Apellido = cmd.Parameters["@APELLIDO"].Value.ToString();
        //                l.FechaNac = Convert.ToDateTime(cmd.Parameters["@FECHA_NAC"].Value);
        //                l.FechaIngreso = Convert.ToDateTime(cmd.Parameters["@FECHA_INGRESO"].Value);
        //                l.Direccion = cmd.Parameters["@DIRECCION"].Value.ToString();
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //}

        public List<Luchador> get_Luchador(string cnn, string rut)
        {
            Luchador l = new Luchador();
            List<Luchador> result = new List<Luchador>();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (cmd.Connection = new SqlConnection(cnn))
                    {
                        cmd.CommandText = CALL_SELECT_USUARIO_PR;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@RUT", SqlDbType.VarChar, 50).Value = rut;
                        cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@APELLIDO", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@FECHA_NAC", SqlDbType.Date).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@FECHA_INGRESO", SqlDbType.Date).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        //SqlDataReader rs = cmd.ExecuteReader();
                        l.Nombre = cmd.Parameters["@NOMBRE"].Value.ToString();
                        l.Apellido = cmd.Parameters["@APELLIDO"].Value.ToString();
                        l.FechaNac = Convert.ToDateTime(cmd.Parameters["@FECHA_NAC"].Value);
                        l.FechaIngreso = Convert.ToDateTime(cmd.Parameters["@FECHA_INGRESO"].Value);
                        l.Direccion = cmd.Parameters["@DIRECCION"].Value.ToString();
                        //while (rs.Read())
                        //{
                        //    l.set(rs);
                        //    result.Add(l);
                        //}
                        //rs.Close();
                        cmd.Connection.Close();
                        cmd.Connection.Dispose();
                    }
                }
            }
            catch (Exception e)
            {

            }
            return result;
        }
    }
}
