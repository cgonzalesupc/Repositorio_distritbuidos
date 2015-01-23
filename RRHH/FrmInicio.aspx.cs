using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RRHH
{
    public partial class FrmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verSession();
            this.Title = "MODULO DE RECURSOS HUMANOS UPC";
            int hora = DateTime.Now.Hour;

            if (hora < 12)
            {
                Label3.Text = "¡BUENOS DÍAS!";
            }
            else if (hora < 19)
            {
                Label3.Text = "¡BUENAS TARDES!";
            }
            else
            {
                Label3.Text = "¡BUENAS NOCHES!";
            }

            if (!Page.IsPostBack)
            {


                Label4.Text = Session["nombre"].ToString() +" "+ Session["paterno"].ToString() + " " + Session["materno"].ToString();

                
            }
        }
    }
}