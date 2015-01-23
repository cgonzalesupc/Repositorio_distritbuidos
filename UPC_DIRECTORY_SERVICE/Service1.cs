using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace UPC_DIRECTORY_SERVICE
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {

            return composite;
        }

        public CompositeType GetDatosTrabajador(string Usuario, string clave)
        {


            SqlConnection objConnection = new SqlConnection();
            DataSet ObjDataset = new DataSet();
            SqlDataAdapter objAdapater = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand
        ("Select * from T_TRABAJADORES where USUARIO='" + Usuario.ToString() + "' and PASSWORD='" + clave.ToString() + "'");
            objConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CnnSQL"].ToString();
            objConnection.Open();
            objCommand.Connection = objConnection;
            objAdapater.SelectCommand = objCommand;
            objAdapater.Fill(ObjDataset);
            CompositeType composite = new CompositeType();
            if (ObjDataset.Tables.Count > 0)
            {
                composite.Nombre = ObjDataset.Tables[0].Rows[0][1].ToString();
                composite.Ape_paterno = ObjDataset.Tables[0].Rows[0][2].ToString();
                composite.Ape_materno = ObjDataset.Tables[0].Rows[0][3].ToString();
            }
            objConnection.Close();


            return composite;
        }

        public Personal_RENIEC Obtener_Reniec(int Dni)
        {


            SqlConnection objConnection = new SqlConnection();
            DataSet ObjDataset = new DataSet();
            SqlDataAdapter objAdapater = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand
        ("Select * from T_PERSONA where NRO_DOCUMENTO='" + Dni.ToString() + "'");
            objConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CnnReniec"].ToString();
            objConnection.Open();
            objCommand.Connection = objConnection;
            objAdapater.SelectCommand = objCommand;
            objAdapater.Fill(ObjDataset);
            Personal_RENIEC composite = new Personal_RENIEC();
            if (ObjDataset.Tables.Count > 0)
            {
                composite.Nombre = ObjDataset.Tables[0].Rows[0][1].ToString();
                composite.Ape_paterno = ObjDataset.Tables[0].Rows[0][2].ToString();
                composite.Ape_materno = ObjDataset.Tables[0].Rows[0][3].ToString();
                composite.Domicilio1 = ObjDataset.Tables[0].Rows[0][4].ToString();
                composite.Est_civil1 = ObjDataset.Tables[0].Rows[0][5].ToString();
                composite.DNI1 = Convert.ToInt32(ObjDataset.Tables[0].Rows[0][6].ToString());
                composite.Sexo = ObjDataset.Tables[0].Rows[0][7].ToString();
                composite.Nacionalidad = ObjDataset.Tables[0].Rows[0][8].ToString();
                composite.Departamento1 = ObjDataset.Tables[0].Rows[0][9].ToString();
                composite.Provincia = ObjDataset.Tables[0].Rows[0][10].ToString();
                composite.Distrito = ObjDataset.Tables[0].Rows[0][11].ToString();
                composite.Foto = ObjDataset.Tables[0].Rows[0][12].ToString();
                
            }
            objConnection.Close();


            return composite;
        }
    }
}
