using System;
using Negocio.Business;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace CohabManager
{
    public partial class ConsultaLuchador : System.Web.UI.Page
    {
        #region VARIABLES
        private static string CONSULTA_DAO = "SQLSERVER";
        string connectionString = ConfigurationManager.ConnectionStrings[CONSULTA_DAO].ConnectionString;
        #endregion
        Neg n = new Neg();

        protected void Page_Load(object sender, EventArgs e)
        {
            txtRut_c.Attributes.Add("placeholder", "Rut");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            List<string> StringList = new List<string>();
            StringList= n.get_Luchador(connectionString, txtRut_c.Text);
            txtNombre_c.Text = StringList[0];
            txtApellido_c.Text = StringList[1];
            
        }
    }
}