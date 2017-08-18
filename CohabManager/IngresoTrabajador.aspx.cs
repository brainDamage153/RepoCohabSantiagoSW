using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio.Business;
using System.Configuration;


namespace CohabManager
{
    public partial class IngresoTrabajador : System.Web.UI.Page
    {
        #region
        private static string CONSULTA_DAO = "SQLSERVER";
        string connectionString = ConfigurationManager.ConnectionStrings[CONSULTA_DAO].ConnectionString;
        string _rut;
        string _nombre;
        string _apellido;
        DateTime _fechaNac;
        DateTime _fechaIngreso;
        string _direccion;
        #endregion

        Neg n = new Neg();

        protected void Page_Load(object sender, EventArgs e)
        {
            txtRut_t.Attributes.Add("placeHolder", "Rut");
            txtNombre_t.Attributes.Add("placeHolder", "Nombre");
            txtApellido_t.Attributes.Add("placeholder", "Apellido");
            txtFechaNac_t.Attributes.Add("placeholder", "Fecha de Nacimiento"); //cambiar a calendario
            txtFechaIngreso_t.Attributes.Add("placeholder", "Fecha Ingreso"); //cambiar a calendario
            txtDireccion_t.Attributes.Add("placeholder", "Dirección");
        }

        public void clearFieldsTrabajador()
        {
            txtRut_t.Text = "";
            txtNombre_t.Text = "";
            txtApellido_t.Text = "";
            txtFechaNac_t.Text = "";
            txtFechaIngreso_t.Text = "";
            txtDireccion_t.Text = "";
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            _rut = txtRut_t.Text;
            _nombre = txtNombre_t.Text;
            _apellido = txtApellido_t.Text;
            _fechaNac = Convert.ToDateTime(txtFechaNac_t.Text);
            _fechaIngreso = Convert.ToDateTime(txtFechaIngreso_t.Text);
            _direccion = txtDireccion_t.Text;
            n.setIngresoTrabajador(connectionString, _rut, _nombre, _apellido, _fechaNac, _fechaIngreso, _direccion);
            clearFieldsTrabajador();
        }
    }
}