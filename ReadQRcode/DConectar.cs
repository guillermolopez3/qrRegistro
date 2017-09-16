
using System;
using System.Collections.Generic;


using System.Data;
using System.Data.SqlClient;

namespace ReadQRcode
{
    public  class DConectar
    {
        private string conec = Properties.Settings.Default.cn;

        public DataTable  consultar(string valor)
        {
            DataTable resultado = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = conec;
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("persona_OBTENER_DATOS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DNI", SqlDbType.Float).Value = valor;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(resultado);


            }
            catch (SqlException e)
            {
               resultado = null;
            }
            catch (Exception e)
            {
                resultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return resultado;
        }

        public DataTable traerInscriptos(string valor)
        {
            DataTable resultado = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = conec;
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("colegio_OBTENER_DATOS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = valor;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(resultado);


            }
            catch (SqlException e)
            {
                resultado = null;
            }
            catch (Exception e)
            {
                resultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return resultado;
        }

        //inserta la asistencia
        public string Insertar(List<String> lista)
        {
            string rta = "";
            SqlTransaction trans = null;
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = conec;
                sqlCon.Open(); //abro la conexion
                trans = sqlCon.BeginTransaction();

                foreach(String lis in lista)
                {
                    string id = lis.ToString();
                    SqlCommand cmd = new SqlCommand("asistencia_REGISTRAR", sqlCon); //paso como parámetro el nombre del SP + la conexion
                    cmd.CommandType = CommandType.StoredProcedure; //le digo q es un procedimiento almacenado
                                                                   //cmd.Transaction = tran;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;



                    cmd.Transaction = trans;
                    cmd.ExecuteNonQuery();

                }

                
                //una vez guardado el articulo, lo cargo en el stock, en el depósito central, de esta manera puedo controlar el stock
               
                trans.Commit();
                rta = "ok";
            }
            catch (SqlException er) //capuro el error
            {
                rta = "error";
                trans.Rollback();
            }
            catch (Exception ex)
            {
                rta = "error";
                trans.Rollback();
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rta;
        }


        public DataTable obtenerDatosCole(string cue)
        {
            DataTable resultado = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = conec;
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("colegio_OBTENER_DATOS_POR_CUE", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CUE", SqlDbType.BigInt).Value = cue;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(resultado);


            }
            catch (SqlException e)
            {
                string err = e.ToString();
                resultado = null;
            }
            catch (Exception e)
            {
                resultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return resultado;
        }

        public string InsertarPersona(string apell,string nom,string dni, string mail,bool es_doc ,string id)
        {
            string rta = "";
            SqlTransaction trans = null;
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = conec;
                sqlCon.Open(); //abro la conexion
                trans = sqlCon.BeginTransaction();

                SqlCommand cmd = new SqlCommand("persona_INSERTAR", sqlCon); 
                cmd.CommandType = CommandType.StoredProcedure; 

                cmd.Parameters.Add("@APELLIDO", SqlDbType.VarChar).Value = apell;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = dni;

                if(string.IsNullOrEmpty(mail))
                {
                    cmd.Parameters.Add("@MAIL", SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MAIL", SqlDbType.VarChar).Value = mail;
                }
                cmd.Parameters.Add("@CUE", SqlDbType.BigInt).Value = id;

                cmd.Parameters.Add("@DOCENTE", SqlDbType.Bit).Value = es_doc;


                cmd.Transaction = trans;
                    cmd.ExecuteNonQuery();

                trans.Commit();
                rta = "ok";
            }
            catch (SqlException er) //capuro el error
            {
                rta = "error";
                trans.Rollback();
            }
            catch (Exception ex)
            {
                rta = "error";
                trans.Rollback();
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rta;
        }


        public DataTable consultarRegistroManualmente(string valor)
        {
            DataTable resultado = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = conec;
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("CARGAR_GRILLA_ASISTENCIA_MANUAL", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CUE", SqlDbType.BigInt).Value = valor;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(resultado);


            }
            catch (SqlException e)
            {
                resultado = null;
            }
            catch (Exception e)
            {
                resultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return resultado;
        }

        public DataTable colegiosGetAll()
        {
            DataTable resultado = new DataTable();
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = conec;
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("colegio_GEL_ALL", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

               

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(resultado);


            }
            catch (SqlException e)
            {
                resultado = null;
            }
            catch (Exception e)
            {
                resultado = null;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return resultado;
        }


    }

   


}



