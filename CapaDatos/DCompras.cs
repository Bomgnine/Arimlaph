using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCompras
    {
        private int _Operacion;
        private string _Fecha;
        private string  _Nombre;
        private string _RIF;
        private string _Factura;
        private string _Control;
        private string _Maquina;
        private double _Base;
        private double _Impuesto;
        private double _Total;
        private string _TextoBuscar;

        public int Operacion { get => _Operacion; set => _Operacion = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string RIF { get => _RIF; set => _RIF = value; }
        public string Factura { get => _Factura; set => _Factura = value; }
        public string Control { get => _Control; set => _Control = value; }
        public string Maquina { get => _Maquina; set => _Maquina = value; }
        public double Base { get => _Base; set => _Base = value; }
        public double Impuesto { get => _Impuesto; set => _Impuesto = value; }
        public double Total { get => _Total; set => _Total = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public DCompras()
        {

        }
        public DCompras(int operacion, string fecha, string nombre, string rif, string factura, string control,
             string maquina, double baseI, double impuesto, double total)
        {
            this.Operacion = operacion;
            this.Fecha = fecha;
            this.Nombre = nombre;
            this.RIF = rif;
            this.Factura = factura;
            this.Control = control;
            this.Maquina = maquina;
            this.Base = baseI;
            this.Total = total;
        }

        public string Insertar(DCompras Compras)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_compras";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParOperacion = new SqlParameter();
                ParOperacion.ParameterName = "@operacion";
                ParOperacion.SqlDbType = SqlDbType.Int;
                ParOperacion.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParOperacion);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Compras.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParRif = new SqlParameter();
                ParRif.ParameterName = "@rif";
                ParRif.SqlDbType = SqlDbType.VarChar;
                ParRif.Size = 50;
                ParRif.Value = Compras.RIF;
                SqlCmd.Parameters.Add(ParRif);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Compras.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParFactura = new SqlParameter();
                ParFactura.ParameterName = "@factura";
                ParFactura.SqlDbType = SqlDbType.VarChar;
                ParFactura.Size = 50;
                ParFactura.Value = Compras.Factura;
                SqlCmd.Parameters.Add(ParFactura);

                SqlParameter ParControl = new SqlParameter();
                ParControl.ParameterName = "@control";
                ParControl.SqlDbType = SqlDbType.VarChar;
                ParControl.Size = 50;
                ParControl.Value = Compras.Control;
                SqlCmd.Parameters.Add(ParControl);

                SqlParameter ParMaquina = new SqlParameter();
                ParMaquina.ParameterName = "@maquina";
                ParMaquina.SqlDbType = SqlDbType.VarChar;
                ParMaquina.Size = 50;
                ParMaquina.Value = Compras.Maquina;
                SqlCmd.Parameters.Add(ParMaquina);

                SqlParameter ParBase = new SqlParameter();
                ParBase.ParameterName = "@base";
                ParBase.SqlDbType = SqlDbType.Decimal;
                ParBase.Value = Compras.Base;
                SqlCmd.Parameters.Add(ParBase);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@impuesto";
                ParIva.SqlDbType = SqlDbType.Decimal;
                ParIva.Value = Compras.Impuesto;
                SqlCmd.Parameters.Add(ParIva);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Decimal;
                ParTotal.Value = Compras.Total;
                SqlCmd.Parameters.Add(ParTotal);

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
        public string Editar(DCompras Compras)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_compras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParOperacion = new SqlParameter();
                ParOperacion.ParameterName = "@operacion";
                ParOperacion.SqlDbType = SqlDbType.Int;
                ParOperacion.Value = Compras.Operacion;
                SqlCmd.Parameters.Add(ParOperacion);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Compras.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParRif = new SqlParameter();
                ParRif.ParameterName = "@rif";
                ParRif.SqlDbType = SqlDbType.VarChar;
                ParRif.Size = 50;
                ParRif.Value = Compras.RIF;
                SqlCmd.Parameters.Add(ParRif);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Compras.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParFactura = new SqlParameter();
                ParFactura.ParameterName = "@factura";
                ParFactura.SqlDbType = SqlDbType.VarChar;
                ParFactura.Size = 50;
                ParFactura.Value = Compras.Factura;
                SqlCmd.Parameters.Add(ParFactura);

                SqlParameter ParControl = new SqlParameter();
                ParControl.ParameterName = "@control";
                ParControl.SqlDbType = SqlDbType.VarChar;
                ParControl.Size = 50;
                ParControl.Value = Compras.Control;
                SqlCmd.Parameters.Add(ParControl);

                SqlParameter ParMaquina = new SqlParameter();
                ParMaquina.ParameterName = "@maquina";
                ParMaquina.SqlDbType = SqlDbType.VarChar;
                ParMaquina.Size = 50;
                ParMaquina.Value = Compras.Maquina;
                SqlCmd.Parameters.Add(ParMaquina);

                SqlParameter ParBase = new SqlParameter();
                ParBase.ParameterName = "@base";
                ParBase.SqlDbType = SqlDbType.Decimal;
                ParBase.Value = Compras.Base;
                SqlCmd.Parameters.Add(ParBase);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@impuesto";
                ParIva.SqlDbType = SqlDbType.Decimal;
                ParIva.Value = Compras.Impuesto;
                SqlCmd.Parameters.Add(ParIva);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Decimal;
                ParTotal.Value = Compras.Total;
                SqlCmd.Parameters.Add(ParTotal);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se editó el registro";
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
        public string Eliminar(DCompras Compras)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminar_comprar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParOperacion = new SqlParameter();
                ParOperacion.ParameterName = "@operacion";
                ParOperacion.SqlDbType = SqlDbType.Int;
                SqlCmd.Parameters.Add(ParOperacion);

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
        public DataTable Buscar(DCompras Compras)
        {
            DataTable DtResultado = new DataTable("compras");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_compras";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextobuscar = new SqlParameter();
                ParTextobuscar.ParameterName = "@textobuscar";
                ParTextobuscar.SqlDbType = SqlDbType.VarChar;
                ParTextobuscar.Size = 50;
                ParTextobuscar.Value = Compras.TextoBuscar;
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
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("compras");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_compras";
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
    }
}
