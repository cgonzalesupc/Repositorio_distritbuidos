﻿using System;
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
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;




namespace RRHH
{
    public partial class FrmListadoPersonal : System.Web.UI.Page
    {
        WebServicePostulante.TrabajadorWSClient ws = new WebServicePostulante.TrabajadorWSClient();
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
            string id_empresa = Session["id_empresa"].ToString();


            //gvListado.DataSource = bl.ObtenerListadoPersonal(be);
            gvListado.DataSource = ws.filtrarTodos(id_empresa, "", "", ""); 
            gvListado.DataBind();

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           
            
            T_TRABAJADORES_DIRECTORY be = new T_TRABAJADORES_DIRECTORY();
            txtNombre.Text = ws.obtenerUno(txtBuscar_DNI.Text).nombres;
            txtPaterno.Text = ws.obtenerUno(txtBuscar_DNI.Text).apePat;
            txtMaterno.Text = ws.obtenerUno(txtBuscar_DNI.Text).apeMat;
            txtSexo.Text = ws.obtenerUno(txtBuscar_DNI.Text).correo;
            txtEstadoCivil.Text = ws.obtenerUno(txtBuscar_DNI.Text).estadoCivil;
            txtNacionalidad.Text = ws.obtenerUno(txtBuscar_DNI.Text).codigoNacionalidad;
            txtDepartamento.Text = ws.obtenerUno(txtBuscar_DNI.Text).codigoDepartamento;
            txtProvincia.Text = ws.obtenerUno(txtBuscar_DNI.Text).codigoProvincia;
            txtDistrito.Text = ws.obtenerUno(txtBuscar_DNI.Text).codigoDistrito;
            txtDomicilio.Text = ws.obtenerUno(txtBuscar_DNI.Text).direccion;
            imgFoto.ImageUrl = "~/FOTOS/" + ws.obtenerUno(txtBuscar_DNI.Text).nombres+".jpg";
            //txtPaterno.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Ape_paterno;
            //txtMaterno.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Ape_materno;
            //txtSexo.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Sexo;
            //txtEstadoCivil.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Est_civil1;
            //txtNacionalidad.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Nacionalidad;
            //txtDepartamento.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Departamento1;
            //txtProvincia.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Provincia;
            //txtDistrito.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Distrito;
            //txtDomicilio.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Domicilio1;
            //imgFoto.ImageUrl = "~/FOTOS/" + service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Foto;
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
            string resultado = consumirRest();
            
            //if (btnCambio.Text.Equals("Guardar"))
            //{

            //    _bl.NuevoPersonal(_be);
            //    ScriptManager.RegisterStartupScript(this.PnlMantenimiento, GetType(), "Script", MessageBox("Grabacion Satisfactoria."), true);
            //}
            //else
            //{
            //    _be.id_trabajador = Convert.ToInt16(hdnIdPersonal.Value);
            //    _bl.ActualizarPersonal(_be);
            //    ScriptManager.RegisterStartupScript(this.PnlMantenimiento, GetType(), "Script", MessageBox("Actualizacion Satisfactoria."), true);
            //}

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
                    
                    int index = int.Parse(e.CommandArgument.ToString());
                    GridViewRow row;
                    PnlListado.Visible = false;
                    PnlMantenimiento.Visible = true;
                    btnCambio.Text = "Actualizar";

                    if (gvListado.PageIndex == 0)
                    {
                        row = gvListado.Rows[index];
                        editar(gvListado.DataKeys[row.RowIndex].Values[0].ToString());
                    }

                    
                }
                else if (e.CommandName.Equals("Del"))
                {
                    GridViewRow row;
                    int index = int.Parse(e.CommandArgument.ToString());
                    row = gvListado.Rows[index];
                   
                    T_PERSONAL_BL _bl = new T_PERSONAL_BL();

                    int CODIGO = Convert.ToInt16(gvListado.DataKeys[row.RowIndex].Values[0].ToString());
                    _bl.Eliminar(CODIGO);

                    listar();
                }
           
        }

        public void editar(string codigo) {
            int codigo1 = Convert.ToInt16(codigo);
            T_PERSONAL_BL _bl = new T_PERSONAL_BL();

            DataTable dt = _bl.ObtenerUnoPersonal(codigo1).Tables[0];

            txtBuscar_DNI.Text = dt.Rows[0]["NRO_DOCUMENTO"].ToString().Trim();
            txtNombre.Text = dt.Rows[0]["NOMBRE"].ToString().Trim();
            txtPaterno.Text = dt.Rows[0]["APE_PATERNO"].ToString().Trim();
            txtMaterno.Text = dt.Rows[0]["APE_MATERNO"].ToString().Trim();
            txtEstadoCivil.Text = dt.Rows[0]["ESTADO_CIVIL"].ToString().Trim();
            txtSexo.Text = dt.Rows[0]["SEXO"].ToString().Trim();
            txtNacionalidad.Text = dt.Rows[0]["DES_NACIONALIDAD"].ToString().Trim();
            txtDepartamento.Text = dt.Rows[0]["DEPARTAMENTO"].ToString().Trim();
            txtProvincia.Text = dt.Rows[0]["PROVINCIA"].ToString().Trim();
            txtDistrito.Text = dt.Rows[0]["DISTRITO"].ToString().Trim();
            txtDomicilio.Text = dt.Rows[0]["DIRECCION"].ToString().Trim();
            hdnIdPersonal.Value = dt.Rows[0]["id"].ToString().Trim();
            imgFoto.ImageUrl = "~/FOTOS/" + dt.Rows[0]["FOTO"].ToString().Trim();
            ImageButton1.Visible = false;
            txtBuscar_DNI.Enabled = false;
        }
        public static string MessageBox(string var_mensaje)
        {
            return "window.alert('" + var_mensaje + "');";
        }

        public void limpiarMant() {

            txtBuscar_DNI.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtEstadoCivil.Text = "";
            txtSexo.Text = "";
            txtNacionalidad.Text = "";
            txtDepartamento.Text = "";
            txtProvincia.Text = "";
            txtDistrito.Text = "";
            txtDomicilio.Text = "";
            hdnIdPersonal.Value = "";
            imgFoto.ImageUrl = "";
        }


       

        public string consumirRest() {

           
            HttpWebRequest reqG = (HttpWebRequest)WebRequest
                           .Create("http://localhost:49525/Service1.svc/Actualizar");
            reqG.Method = "GET";
            HttpWebResponse resG = (HttpWebResponse)reqG.GetResponse();
            StreamReader readerG = new StreamReader(resG.GetResponseStream());
            string rptaJsonG = readerG.ReadToEnd();
            JavaScriptSerializer jsG = new JavaScriptSerializer();
            string rptaObtenidaG = jsG.Deserialize<string>(rptaJsonG);

            return rptaObtenidaG;
        }

        
    }
}