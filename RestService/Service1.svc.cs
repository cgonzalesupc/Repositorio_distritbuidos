using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Activation;
using UPC_DATOS;
using UPC_ENTIDADES;
using System.Data;

namespace RestService
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Actualizar", ResponseFormat = WebMessageFormat.Json)]
        public string Actualizar(string codigo)
        {
            //T_PERSONAL_DAO be = new T_PERSONAL_DAO();
            //int respuest= be.UpdateTrabajador(codigo);
            string cesar = "salio por fin ";
            return cesar;
        }
    }
}
