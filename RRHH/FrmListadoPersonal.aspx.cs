using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UPC_ENTIDADES;
using UPC_LOGICA;
using UPC_DATOS;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



namespace RRHH
{
    public partial class FrmListadoPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PnlListado.Visible = true;
                PnlMantenimiento.Visible = false;
                listar();
            }
        }


        public void listar() {

            T_PERSONAL be = new T_PERSONAL();
            T_PERSONAL_BL bl = new T_PERSONAL_BL();

            be.nombre = txtBuscar.Text.ToString();

            gvListado.DataSource = bl.ObtenerListadoPersonal(be);
            gvListado.DataBind();

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            T_TRABAJADORES_DIRECTORY be = new T_TRABAJADORES_DIRECTORY();
            txtNombre.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text)).Nombre;
            txtPaterno.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Ape_paterno;
            txtMaterno.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Ape_materno;
            txtSexo.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Sexo;
            txtEstadoCivil.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Est_civil1;
            txtNacionalidad.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Nacionalidad;
            txtDepartamento.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Departamento1;
            txtProvincia.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Provincia;
            txtDistrito.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Distrito;
            txtDomicilio.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Domicilio1;
            imgFoto.ImageUrl = "~/FOTOS/" + service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Foto;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            PnlListado.Visible = false;
            PnlMantenimiento.Visible = true;
            btnCambio.Text = "Guardar";
        }

        protected void btnCambio_Click(object sender, EventArgs e)
        {
            T_PERSONAL _be = new T_PERSONAL();
            T_PERSONAL_BL _bl = new T_PERSONAL_BL();

            _be.nombre = txtNombre.Text;
            _be.ape_paterno = txtPaterno.Text;
            _be.ape_materno = txtMaterno.Text;
            _be.sexo = txtSexo.Text;
            _be.estado_civil = txtEstadoCivil.Text;
            _be.des_nacionalidad = txtNacionalidad.Text;
            _be.departamento = txtDepartamento.Text;
            _be.provincia = txtProvincia.Text;
            _be.distrito = txtDistrito.Text;
            _be.nro_documento =Convert.ToInt32(txtBuscar_DNI.Text);
            _be.direccion = txtDomicilio.Text;


            if (btnCambio.Text.Equals("Guardar")) {

                _bl.NuevoPersonal(_be);
                ScriptManager.RegisterStartupScript(this.PnlMantenimiento, GetType(), "Script", MessageBox("Grabacion Satisfactoria."), true);
            }

            listar();
            PnlMantenimiento.Visible = false;
            PnlListado.Visible = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            PnlListado.Visible = true;
            PnlMantenimiento.Visible = false;
        }
        protected void gvListado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edt"))
                {
                    PnlListado.Visible = false;
                    PnlMantenimiento.Visible = true;

                    btnCambio.Text = "Actualizar";
                    
                    //editar(key.Value.ToString());
                }
                else if (e.CommandName.Equals("Del"))
                {

                    DataKey key = gvListado.DataKeys[0];
                   
                    T_PERSONAL_BL _bl = new T_PERSONAL_BL();

                    int CODIGO = Convert.ToInt16(key.Value.ToString());
                    _bl.Eliminar(CODIGO);

                    listar();
                }
           
        }
        public static string MessageBox(string var_mensaje)
        {
            return "window.alert('" + var_mensaje + "');";
        }
    }
}