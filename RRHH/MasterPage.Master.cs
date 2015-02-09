using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using UPC_DATOS;
using UPC_ENTIDADES;
using UPC_LOGICA;


namespace MTC_MOREC.Master
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
           
                // Borrar toda la información del histórico
                Response.ExpiresAbsolute = DateTime.Now.AddDays(-1);
                Response.AddHeader("pragma", "no-cache");
                Response.AddHeader("cache-control", "private");
                Response.CacheControl = "no-cache";

                //verSession();
                if (!Page.IsPostBack)
                {
                    string nombre = Session["nombre"].ToString();
                    string mater = Session["materno"].ToString();
                    string pater = Session["paterno"].ToString();
                    int id_empresa = Convert.ToInt16(Session["id_empresa"].ToString());
                    lblUsuario.Text = nombre.Substring(0, 1) + pater;

                }
           
           

        }


        protected void btnCerrar_Click(object sender, ImageClickEventArgs e)
        {
                clsSession();
        }

        protected void btnInicio_Click(object sender, ImageClickEventArgs e)
        {
           
                Response.Redirect("~/FrmMain.aspx", false);
           
        }

        

        #endregion

        #region Métodos

        protected void verSession()
        {
            if (Session["Usuario"] == null && Session["Perfil"] == null)
            {
                Response.Redirect(ConfigurationManager.AppSettings.Get("RutaInicio"), true);
            }
        }

        protected void clsSession()
        {
            Session["Session"] = null;
            Session["Usuario"] = null;
            Session["Perfil"] = null;
            Response.Redirect(ConfigurationManager.AppSettings.Get("RutaInicio"), false);
        }



        #endregion

    
    }
}