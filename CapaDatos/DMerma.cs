using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DMerma
    {
        private string _Fecha;
        private string _TipoMerma;

        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string TipoMerma { get => _TipoMerma; set => _TipoMerma = value; }

        public DMerma()
        {

        }
        public DMerma(string fecha, string tipomerma)
        {
            this.Fecha = fecha;
            this.TipoMerma = tipomerma;
        }

        public string Isertar(DMerma Merma)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_merma";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;;
                ParFecha.Value = Merma.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParMermaTipo = new SqlParameter();
                ParMermaTipo.ParameterName = "@tipomerma";
                ParMermaTipo.SqlDbType = SqlDbType.VarChar;
                ParMermaTipo.Size = 50;
                ParMermaTipo.Value = Merma.TipoMerma;
                SqlCmd.Parameters.Add(ParMermaTipo);

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
