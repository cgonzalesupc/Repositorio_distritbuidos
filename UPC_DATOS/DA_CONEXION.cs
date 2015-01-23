using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace UPC_DATOS
{
    public class DA_CONEXION
    {
        private SqlConnection SqlClient;    

        public SqlConnection SqlClientUPC
        {
            get
            {
                if (SqlClient == null)
                {
                    SqlClient = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                }
                return SqlClient;
            }
        }
    }
}
