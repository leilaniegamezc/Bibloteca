using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace CapaDatos
{
    public class CDLibros
    {
        public int Idcliente { get; set; }
        public string Nombre { get; set; }
        public string IdEditor { get; set; }

        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable result = new DataTable("Bibloteca");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand cmd = new SqlCommand("speditar_Libros", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(result);
            }
            catch (Exception ex)
            {
                result = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }
            }
            return result;

        }
        protected void CloseConIfOpen(ref SqlConnection con)
        {
            if (con.State == ConnectionState.Open) con.Close();
        }

        public string Guardar(CDLibros cli)
        {
            string result = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("spGuardar_Libro", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idLibro", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@Nombre_libro", cli.Nombre);
                cmd.Parameters.AddWithValue("@idEditor", cli.Nombre);

                result = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }
            }
            return result;
        }
        public string Editar(CDLibros cli)
        {
            string result = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("speditar_Libros", conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@idLibro", cli.Idcliente);
                cmd.Parameters.AddWithValue("Nombre_libro", cli.Nombre);
                cmd.Parameters.AddWithValue("@idEditor", cli.Nombre);




                result = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }
            }
            return result;
        }
        public string Eliminar(CDLibros cli)
        {
            string result = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("speliminar_cliente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idcliente", cli.Idcliente);

                result = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }
            }
            return result;
        }
        public DataTable BuscarDni(CDLibros cli)
        {
            DataTable result = new DataTable("cliente");
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("spbuscar_cliente_dni", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", cli.Buscar);
                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(result);

            }
            catch (Exception ex)
            {
                result = null;
                throw ex;

            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return result;
        }


        public DataTable BuscarNombre(CDLibros cli)
        {
            DataTable result = new DataTable("Bibloteca");
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Conn;
                SqlCommand cmd = new SqlCommand("spbuscar_libro_nombre", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue($"@{nameof(Nombre).ToLower()}", cli.Buscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(cmd);
                sqlDat.Fill(result);
            }
            catch (Exception ex)
            {
                result = null;
                throw ex;
            }
            finally { CloseConIfOpen(ref con); }

            return result;
        }

    }
}

