using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DActualizarPrecios
    {
        private double _Preciodolar;

        public double Preciodolar { get => _Preciodolar; set => _Preciodolar = value; }

        public DActualizarPrecios()
        {

        }
        public DActualizarPrecios(double preciodolar)
        {
            this.Preciodolar = preciodolar;
        }
        public string Actualizar(DActualizarPrecios Precio)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spactualizar_pvpbs";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@preciodolar";
                ParPrecio.SqlDbType = SqlDbType.Decimal;
                ParPrecio.Value = Precio.Preciodolar;
                SqlCmd.Parameters.Add(ParPrecio);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";
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
    }
}
