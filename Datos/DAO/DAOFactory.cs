﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos.DAO
{
    class DAOFactory
    {
        private static DAOFactory factory;
        public static string CONSULTA_DAO = "SQLSERVER";

        public static DAOFactory getInstance()
        {
            if (null == factory)
            {
                factory = new DAOFactory();
            }
            return factory;
        }

        //public static  getDAO(string connectionStringName)
        //{
        //    var connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

        //    switch (connectionStringName)
        //    {
        //        case "SQLSERVER":

        //            return new SqlServerConexion(connectionString);

        //        default:
        //            throw new Exception();
        //    }
        //}
    }
}
