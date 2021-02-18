using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DMermatipo
    {
        private int _Id;
        private string _Nombre;
        private string _Descripcion;

        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        public DMermatipo()
        {

        }
        public DMermatipo(int id, string nombre, string descripcion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        public string Insertar(DMermatipo Mermatipo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_mermatipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdmermatipo = new SqlParameter();
                ParIdmermatipo.ParameterName = "@id";
                ParIdmermatipo.SqlDbType = SqlDbType.Int;
                ParIdmermatipo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdmermatipo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Mermatipo.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Mermatipo.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingresó el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return rpta;
        }
        public string Editar(DMermatipo Mermatipo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_mermatipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Mermatipo.Id;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Mermatipo.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Mermatipo.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return rpta;
        }
        public string Eliminar(DMermatipo Mermatipo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_mermatipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Mermatipo.Id;
                SqlCmd.Parameters.Add(ParId);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se eliminó el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return rpta;
        }
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("mermatipo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_mermatipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch 
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    } 
}
