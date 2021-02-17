using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DInventario
    {
        private int _Idarticulo;
        private string _Codigo;
        private string _Nombre;
        private string _Descripcion;
        private int _Inventario;
        private double _Pcompra;
        private double _Pventa;

        public int Idarticulo { get => _Idarticulo; set => _Idarticulo = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Inventario { get => _Inventario; set => _Inventario = value; }
        public double Pcompra { get => _Pcompra; set => _Pcompra = value; }
        public double Pventa { get => _Pventa; set => _Pventa = value; }

        public DInventario()
        {

        }
        public DInventario(int idarticulo, string codigo, string nombre, string descripcion, int inventario,
            double pcompra, double pventa)
        {
            this.Idarticulo = idarticulo;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Inventario = inventario;
            this.Pcompra = pcompra;
            this.Pventa = pventa;
        }

        public DataTable MostrarInventario()
        {
            DataTable DtResultado = new DataTable("articulo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public DataTable BuscarInventario(DInventario Inventario)
        {
            DataTable DtResultado = new DataTable("articulo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@codigo";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 50;
                ParTextobuscar.Value = Inventario.Codigo;
                SqlCmd.Parameters.Add(ParTextobuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public string EditarInventario(DInventario Inventario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Inventario.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParInventario = new SqlParameter();
                ParInventario.ParameterName = "@inventario";
                ParInventario.SqlDbType = SqlDbType.Int;
                ParInventario.Value = Inventario.Inventario;
                SqlCmd.Parameters.Add(ParInventario);

                SqlParameter ParPcompra = new SqlParameter();
                ParPcompra.ParameterName = "@pcompra";
                ParPcompra.SqlDbType = SqlDbType.Decimal;
                ParPcompra.Value = Inventario.Pcompra;
                SqlCmd.Parameters.Add(ParPcompra);

                SqlParameter ParPventa = new SqlParameter();
                ParPventa.ParameterName = "@pventa";
                ParPventa.SqlDbType = SqlDbType.Decimal;
                ParPventa.Value = Inventario.Pventa;
                SqlCmd.Parameters.Add(ParPventa);

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
    }
}
