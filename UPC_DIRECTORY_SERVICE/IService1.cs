using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UPC_DIRECTORY_SERVICE
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        CompositeType GetDatosTrabajador(string usuario, string clave);
        // TODO: agregue aquí sus operaciones de servicio

        [OperationContract]
        Personal_RENIEC Obtener_Reniec(int Dni);
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio
    [DataContract]
    public class CompositeType
    {
        string nombre;
        string ape_paterno;
        string ape_materno;
        string usuario;
        string password;
        string id_empresa;


        [DataMember]
        public string Id_empresa
        {
            get { return id_empresa; }
            set { id_empresa = value; }
        }


        [DataMember]
        public string Ape_paterno
        {
            get { return ape_paterno; }
            set { ape_paterno = value; }
        }

        [DataMember]
        public string Ape_materno
        {
            get { return ape_materno; }
            set { ape_materno = value; }
        }

        [DataMember]
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }

    [DataContract]
    public class Personal_RENIEC
    {
        string nombre;
        string ape_paterno;
        string ape_materno;
        int DNI;
        string Domicilio;
        string Est_civil;
        string sexo;
        string nacionalidad;
        string Departamento;
        string provincia;
        string distrito;
        string foto;

         [DataMember]
        public string Domicilio1
        {
            get { return Domicilio; }
            set { Domicilio = value; }
        }
        
         [DataMember]
        public string Est_civil1
        {
            get { return Est_civil; }
            set { Est_civil = value; }
        }
        
         [DataMember]
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        
         [DataMember]
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
       
         [DataMember]
        public string Departamento1
        {
            get { return Departamento; }
            set { Departamento = value; }
        }
        
         [DataMember]
        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        
         [DataMember]
        public string Distrito
        {
            get { return distrito; }
            set { distrito = value; }
        }
        
         [DataMember]
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }



        [DataMember]
        public int DNI1
        {
            get { return DNI; }
            set { DNI = value; }
        }



        [DataMember]
        public string Ape_paterno
        {
            get { return ape_paterno; }
            set { ape_paterno = value; }
        }

        [DataMember]
        public string Ape_materno
        {
            get { return ape_materno; }
            set { ape_materno = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


    }
}
