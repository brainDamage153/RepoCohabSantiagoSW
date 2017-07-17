using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Negocio.Business;

namespace CohabManager
{
    public partial class IngresoLuchadores : System.Web.UI.Page
    {
        #region VARIABLES
        private static string CONSULTA_DAO = "SQLSERVER";
        string connectionString = ConfigurationManager.ConnectionStrings[CONSULTA_DAO].ConnectionString;
        string _rut;
        string _nombre;
        string _apellido;
        DateTime _fechaNac;
        DateTime _fechaIngreso;
        string _cinturon;
        string _direccion;
        #endregion

        Neg n = new Neg();

        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[CONSULTA_DAO].ConnectionString;

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
            _rut = txtRut.Text;
            _nombre = txtNombre.Text;
            _apellido = txtApellido.Text;
            _fechaNac = Convert.ToDateTime(txtFechaNac.Text);
            _cinturon = Convert.ToString(ddlCinturon.SelectedItem.Text);
            _fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
            _direccion = txtDireccion.Text;

            ClearFieldsLuchador();
            n.setIngresoLuchador
            (
                connectionString,
                _rut,
                _nombre,
                _apellido,
                _fechaNac,
                _cinturon,
                _fechaIngreso,
                _direccion
            );
        }
    }
}