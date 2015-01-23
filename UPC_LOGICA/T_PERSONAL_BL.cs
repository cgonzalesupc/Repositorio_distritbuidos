using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UPC_ENTIDADES;
using UPC_DATOS;

namespace UPC_LOGICA
{
   public class T_PERSONAL_BL
    {
       public DataSet ObtenerListadoPersonal(T_PERSONAL oBE)
       {
           return new T_PERSONAL_DAO().ObtenerListado(oBE);
       }

       public int NuevoPersonal(T_PERSONAL oBE)
       {
           return new T_PERSONAL_DAO().Insert(oBE);
       }
       public int Eliminar(int codigo)
       {
           return new T_PERSONAL_DAO().Delete(codigo);
       }
    }
}
