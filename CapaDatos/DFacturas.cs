using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DFacturas
    {
        private int _Idv;
        private int _Nfactura;
        private int _NControl;
        private string _Fecha;
        private string _Nombre;
        private string _Cedula;
        private string _Telefono;
        private string _Direccion;
        private double _SubTotal;
        private double _IVA;
        private double _Exento;
        private double _Total;
        private double _TotalDolares;

        public int Idv { get => _Idv; set => _Idv = value; }
        public int Nfactura { get => _Nfactura; set => _Nfactura = value; }
        public int NControl { get => _NControl; set => _NControl = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public double SubTotal { get => _SubTotal; set => _SubTotal = value; }
        public double IVA { get => _IVA; set => _IVA = value; }
        public double Exento { get => _Exento; set => _Exento = value; }
        public double Total { get => _Total; set => _Total = value; }
        public double TotalDolares { get => _TotalDolares; set => _TotalDolares = value; }

        public DFacturas()
        {

        }

        public DFacturas(int idv, int nfactura, int ncontrol, string fecha, string nombre, string cedula, string telefono, 
            string direccion, double subtotal, double iva, double exento, double total, double totaldolares)
        {
            this.Idv = idv;
            this.Nfactura = nfactura;
            this.NControl = ncontrol;
            this.Fecha = fecha;
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.SubTotal = subtotal;
            this.IVA = iva;
            this.Exento = exento;
            this.Total = total;
            this.TotalDolares = totaldolares;
        }

        public string Insertar (DFacturas Factura)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIdv = new SqlParameter();
                ParIdv.ParameterName = "@idv";
                ParIdv.SqlDbType = SqlDbType.Int;
                ParIdv.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdv);

                SqlParameter ParNfactura = new SqlParameter();
                ParNfactura.ParameterName = "@nfactura";
                ParNfactura.SqlDbType = SqlDbType.Int;
                ParNfactura.Value = Factura.Nfactura;
                SqlCmd.Parameters.Add(ParNfactura);

                SqlParameter ParNcontrol = new SqlParameter();
                ParNcontrol.ParameterName = "@ncontrol";
                ParNcontrol.SqlDbType = SqlDbType.Int;
                ParNcontrol.Value = Factura.NControl;
                SqlCmd.Parameters.Add(ParNcontrol);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Factura.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Factura.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 256;
                ParCedula.Value = Factura.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 256;
                ParTelefono.Value = Factura.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 256;
                ParDireccion.Value = Factura.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParSubtotal = new SqlParameter();
                ParSubtotal.ParameterName = "@subtotal";
                ParSubtotal.SqlDbType = SqlDbType.Decimal;
                ParSubtotal.Value = Factura.SubTotal;
                SqlCmd.Parameters.Add(ParSubtotal);

                SqlParameter ParIva = new SqlParameter();
                ParIva.ParameterName = "@iva";
                ParIva.SqlDbType = SqlDbType.Decimal;
                ParIva.Value = Factura.IVA;
                SqlCmd.Parameters.Add(ParIva);

                SqlParameter ParExento = new SqlParameter();
                ParExento.ParameterName = "@exento";
                ParExento.SqlDbType = SqlDbType.Decimal;
                ParExento.Value = Factura.Exento;
                SqlCmd.Parameters.Add(ParExento);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Decimal;
                ParTotal.Value = Factura.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParTotaldolares = new SqlParameter();
                ParTotaldolares.ParameterName = "@totaldolares";
                ParTotaldolares.SqlDbType = SqlDbType.Decimal;
                ParTotaldolares.Value = Factura.TotalDolares;
                SqlCmd.Parameters.Add(ParTotaldolares);

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
        public string Eliminar (DFacturas Factura)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdv = new SqlParameter();
                ParIdv.ParameterName = "@idv";
                ParIdv.SqlDbType = SqlDbType.Int;
                ParIdv.Value = Factura.Idv;
                SqlCmd.Parameters.Add(ParIdv);

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
        public DataTable Buscar (DFacturas Factura)
        {
            DataTable DtResultado = new DataTable("factura");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_factura";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdv = new SqlParameter();
                ParIdv.ParameterName = "@idv";
                ParIdv.SqlDbType = SqlDbType.Int;
                ParIdv.Value = Factura.Idv;
                SqlCmd.Parameters.Add(ParIdv);


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
            DataTable DtResultado = new DataTable("factura");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_factura";
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
