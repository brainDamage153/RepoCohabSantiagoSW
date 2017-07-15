using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace CohabManager
{
    public partial class IngresoLuchadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtRut.Attributes.Add("placeHolder", "Rut");
            txtNombre.Attributes.Add("placeHolder", "Nombre");
            txtApellido.Attributes.Add("placeholder","Apellido");
            txtFechaNac.Attributes.Add("placeholder", "Fecha de Nacimiento"); //cambiar a calendario
            txtFechaIngreso.Attributes.Add("placeholder","Fecha Ingreso"); //cambiar a calendario
            txtDireccion.Attributes.Add("placeholder","Dirección");
           
        }

        public void ClearFieldsLuchador()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNac.Text = "";
            txtFechaIngreso.Text = "";
            txtDireccion.Text = "";
            ddlCinturon.SelectedValue = "0";
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            ClearFieldsLuchador();

        }
    }
}