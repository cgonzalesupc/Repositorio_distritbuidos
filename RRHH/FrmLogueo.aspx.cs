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
    public partial class FrmLogueo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          if (!Page.IsPostBack)
          {
                    ScriptManager.GetCurrent(this.Page).SetFocus(txtUsuario);
          }


        }

        protected void btnIngresar_Click(object sender, ImageClickEventArgs e)
        {
           

            ServiceReference2.Service1Client service = new ServiceReference2.Service1Client();
            T_TRABAJADORES_DIRECTORY be = new T_TRABAJADORES_DIRECTORY();
            string nombre =service.GetDatosTrabajador(txtUsuario.Text.ToString(), txtContrasenia.Text.ToString()).Nombre;
            string ape_paterno = service.GetDatosTrabajador(txtUsuario.Text.ToString(), txtContrasenia.Text.ToString()).Ape_paterno;
            string ape_materno = service.GetDatosTrabajador(txtUsuario.Text.ToString(), txtContrasenia.Text.ToString()).Ape_materno;
            Session["nombre"] = nombre;
            Session["paterno"] = ape_paterno;
            Session["materno"] = ape_materno;

            if (nombre != "")
            {
                Response.Redirect("FrmInicio.aspx");
            }
            else
            {
                Response.Redirect("FrmLogueo.aspx");
            }
        }


       
    }
}