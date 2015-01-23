using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC_ENTIDADES;


namespace UPC_DATOS
{
   public class T_PERSONAL_DAO:DA_CONEXION
    {

       public DataSet ObtenerListado(T_PERSONAL oBEGeneral)
       {
           using (SqlCommand dbCmd = new SqlCommand("SPS_LISTADOPERSONAL", SqlClientUPC))
           {
               SqlClientUPC.Open();
               DataSet dsOrl = new DataSet();

               try
               {
                   T_PERSONAL _Be = (T_PERSONAL)oBEGeneral;
                   dbCmd.CommandType = CommandType.StoredProcedure;
                   dbCmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = _Be.nombre;
                   SqlDataAdapter daOrl = new SqlDataAdapter(dbCmd);
                   daOrl.Fill(dsOrl);
               }
               catch (Exception ex)
               {
                   throw ex;
               }
               finally
               {
                   SqlClientUPC.Close();
                   SqlClientUPC.Dispose();
                   dbCmd.Dispose();
               }
               return dsOrl;
           }
       }

       public DataSet ObtenerListado(int codigo)
       {
           using (SqlCommand dbCmd = new SqlCommand("sps_obtenerUno_Personal", SqlClientUPC))
           {
               SqlClientUPC.Open();
               DataSet dsOrl = new DataSet();

               try
               {
                   
                   dbCmd.CommandType = CommandType.StoredProcedure;
                   dbCmd.Parameters.Add("@ID_PERSONAL", SqlDbType.VarChar).Value = codigo;
                   SqlDataAdapter daOrl = new SqlDataAdapter(dbCmd);
                   daOrl.Fill(dsOrl);
               }
               catch (Exception ex)
               {
                   throw ex;
               }
               finally
               {
                   SqlClientUPC.Close();
                   SqlClientUPC.Dispose();
                   dbCmd.Dispose();
               }
               return dsOrl;
           }
       }

       public int Insert(T_PERSONAL oBEGeneral)
       {
           using (SqlCommand dbCmd = new SqlCommand("SPI_NUEVO_PERSONA", SqlClientUPC))
           {
               SqlClientUPC.Open();
               SqlTransaction trans = SqlClientUPC.BeginTransaction(IsolationLevel.ReadCommitted);

               try
               {
                   T_PERSONAL _Be = (T_PERSONAL)oBEGeneral;
                   dbCmd.Transaction = trans;
                   dbCmd.CommandType = CommandType.StoredProcedure;
                   dbCmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = _Be.nombre;
                   dbCmd.Parameters.Add("@PATERNO", SqlDbType.VarChar).Value = _Be.ape_paterno;
                   dbCmd.Parameters.Add("@MATERNO", SqlDbType.VarChar).Value = _Be.ape_materno;
                   dbCmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = _Be.direccion;
                   dbCmd.Parameters.Add("@EST_CIVIL", SqlDbType.VarChar).Value = _Be.estado_civil;
                   dbCmd.Parameters.Add("@NRO_DOCUMENTO", SqlDbType.Int).Value = _Be.nro_documento;
                   dbCmd.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = _Be.sexo;
                   dbCmd.Parameters.Add("@NACIONALIDAD", SqlDbType.VarChar).Value = _Be.des_nacionalidad;
                   dbCmd.Parameters.Add("@DEPARTAMENTO", SqlDbType.VarChar).Value = _Be.departamento;
                   dbCmd.Parameters.Add("@PROVINCIA", SqlDbType.VarChar).Value = _Be.provincia;
                   dbCmd.Parameters.Add("@DISTRITO", SqlDbType.VarChar).Value = _Be.distrito;

                   dbCmd.ExecuteNonQuery();
                   trans.Commit();

                   return 0;
               }
               catch (Exception ex)
               {
                   trans.Rollback();
                   throw ex;
               }
               finally
               {
                   SqlClientUPC.Close();
                   SqlClientUPC.Dispose();
                   trans.Dispose();
                   dbCmd.Dispose();
               }
           }
       }


       public int Update(T_PERSONAL oBEGeneral)
       {
           using (SqlCommand dbCmd = new SqlCommand("SPU_ACTUALIZAR_PERSONA", SqlClientUPC))
           {
               SqlClientUPC.Open();
               SqlTransaction trans = SqlClientUPC.BeginTransaction(IsolationLevel.ReadCommitted);

               try
               {
                   T_PERSONAL _Be = (T_PERSONAL)oBEGeneral;
                   dbCmd.Transaction = trans;
                   dbCmd.CommandType = CommandType.StoredProcedure;
                   dbCmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = _Be.nombre;
                   dbCmd.Parameters.Add("@PATERNO", SqlDbType.VarChar).Value = _Be.ape_paterno;
                   dbCmd.Parameters.Add("@MATERNO", SqlDbType.VarChar).Value = _Be.ape_materno;
                   dbCmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = _Be.direccion;
                   dbCmd.Parameters.Add("@EST_CIVIL", SqlDbType.VarChar).Value = _Be.estado_civil;
                   dbCmd.Parameters.Add("@NRO_DOCUMENTO", SqlDbType.Int).Value = _Be.nro_documento;
                   dbCmd.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = _Be.sexo;
                   dbCmd.Parameters.Add("@NACIONALIDAD", SqlDbType.VarChar).Value = _Be.des_nacionalidad;
                   dbCmd.Parameters.Add("@DEPARTAMENTO", SqlDbType.VarChar).Value = _Be.departamento;
                   dbCmd.Parameters.Add("@PROVINCIA", SqlDbType.VarChar).Value = _Be.provincia;
                   dbCmd.Parameters.Add("@DISTRITO", SqlDbType.VarChar).Value = _Be.distrito;
                   dbCmd.Parameters.Add("@ID_PERSONAL", SqlDbType.VarChar).Value = _Be.id_trabajador;

                   dbCmd.ExecuteNonQuery();
                   trans.Commit();

                   return 0;
               }
               catch (Exception ex)
               {
                   trans.Rollback();
                   throw ex;
               }
               finally
               {
                   SqlClientUPC.Close();
                   SqlClientUPC.Dispose();
                   trans.Dispose();
                   dbCmd.Dispose();
               }
           }
       }

       public  int Delete(int codigo)
       {
           using (SqlCommand dbCmd = new SqlCommand("SPD_ELIMINAR_PERSONAL", SqlClientUPC))
           {
               SqlClientUPC.Open();
               SqlTransaction trans = SqlClientUPC.BeginTransaction(IsolationLevel.ReadCommitted);

               try
               {
                  

                   dbCmd.CommandType = CommandType.StoredProcedure;
                   dbCmd.Transaction = trans;
                   dbCmd.Parameters.Add("@ID_TRABAJADOR", SqlDbType.Int).Value = codigo;

                   dbCmd.ExecuteNonQuery();
                   trans.Commit();

                   return 0;
               }
               catch (Exception ex)
               {
                   trans.Rollback();
                   throw ex;
               }
               finally
               {
                   SqlClientUPC.Close();
                   SqlClientUPC.Dispose();
                   trans.Dispose();
                   dbCmd.Dispose();
               }
           }
       }
    }
}
