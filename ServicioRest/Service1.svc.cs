using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//using System.Messaging;
using System.ServiceModel.Activation;
using UPC_DATOS;


namespace ServicioRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1  
    {

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Actualizar", ResponseFormat = WebMessageFormat.Json)]
        public void RegistrarGalletas(string DNI)
        {
            UPC_DATOS.T_PERSONAL_DAO da = new UPC_DATOS.T_PERSONAL_DAO();

            int flg = da.UpdateTrabajador(DNI);

        }
        
        
    }
}
