using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace RRHH
{
    public partial class pRACTICANDO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpWebRequest reqG = (HttpWebRequest)WebRequest
                           .Create("http://localhost:49929/Service1.svc/Consultas");
            reqG.Method = "GET";
            HttpWebResponse resG = (HttpWebResponse)reqG.GetResponse();
            StreamReader readerG = new StreamReader(resG.GetResponseStream());
            string rptaJsonG = readerG.ReadToEnd();
            JavaScriptSerializer jsG = new JavaScriptSerializer();
            string rptaObtenidaG = jsG.Deserialize<string>(rptaJsonG);
        }
    }
}