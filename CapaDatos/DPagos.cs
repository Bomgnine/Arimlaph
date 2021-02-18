using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPagos
    {
        private int _Idv;
        private string _Fecha;
        private double _Divisas;
        private double _Debito;
        private double _Pagomovil;
        private double _Transferencia;
        private double _Visa;
        private double _Master;
        private double _Efectivo;
        private double _Vuelto;

        public int Idv { get => _Idv; set => _Idv = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public double Divisas { get => _Divisas; set => _Divisas = value; }
        public double Debito { get => _Debito; set => _Debito = value; }
        public double Pagomovil { get => _Pagomovil; set => _Pagomovil = value; }
        public double Transferencia { get => _Transferencia; set => _Transferencia = value; }
        public double Visa { get => _Visa; set => _Visa = value; }
        public double Master { get => _Master; set => _Master = value; }
        public double Efectivo { get => _Efectivo; set => _Efectivo = value; }
        public double Vuelto { get => _Vuelto; set => _Vuelto = value; }

        public DPagos()
        {

        }
        public DPagos(int idv, string fecha, double divisas, double debito, double pagomovil, double transferencia, double visa,
            double master, double efectivo, double vuelto)
        {
            this.Idv = idv;
            this.Fecha = fecha;
            this.Divisas = divisas;
            this.Debito = debito;
            this.Pagomovil = pagomovil;
            this.Transferencia = transferencia;
            this.Visa = visa;
            this.Master = master;
            this.Efectivo = efectivo;
            this.Vuelto = vuelto;
        }
        public string Insertar(DPagos Pagos)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_pagos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdv = new SqlParameter();
                ParIdv.ParameterName = "@idv";
                ParIdv.SqlDbType = SqlDbType.Int;
                ParIdv.Value = Pagos.Idv;
                SqlCmd.Parameters.Add(ParIdv);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Pagos.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParDivisas = new SqlParameter();
                ParDivisas.ParameterName = "@divisas";
                ParDivisas.SqlDbType = SqlDbType.Decimal;
                ParDivisas.Value = Pagos.Divisas;
                SqlCmd.Parameters.Add(ParDivisas);

                SqlParameter ParDebito = new SqlParameter();
                ParDebito.ParameterName = "@debito";
                ParDebito.SqlDbType = SqlDbType.Decimal;
                ParDebito.Value = Pagos.Debito;
                SqlCmd.Parameters.Add(ParDebito);

                SqlParameter ParPagomovil = new SqlParameter();
                ParPagomovil.ParameterName = "@pagomovil";
                ParPagomovil.SqlDbType = SqlDbType.Decimal;
                ParPagomovil.Value = Pagos.Pagomovil;
                SqlCmd.Parameters.Add(ParPagomovil);

                SqlParameter ParTransferencia = new SqlParameter();
                ParTransferencia.ParameterName = "@transferencia";
                ParTransferencia.SqlDbType = SqlDbType.Decimal;
                ParTransferencia.Value = Pagos.Transferencia;
                SqlCmd.Parameters.Add(ParTransferencia);

                SqlParameter ParVisa = new SqlParameter();
                ParVisa.ParameterName = "@visa";
                ParVisa.SqlDbType = SqlDbType.Decimal;
                ParVisa.Value = Pagos.Visa;
                SqlCmd.Parameters.Add(ParVisa);

                SqlParameter ParMaster = new SqlParameter();
                ParMaster.ParameterName = "@master";
                ParMaster.SqlDbType = SqlDbType.Decimal;
                ParMaster.Value = Pagos.Master;
                SqlCmd.Parameters.Add(ParMaster);

                SqlParameter ParEfectivo = new SqlParameter();
                ParEfectivo.ParameterName = "@efectivo";
                ParEfectivo.SqlDbType = SqlDbType.Decimal;
                ParEfectivo.Value = Pagos.Efectivo;
                SqlCmd.Parameters.Add(ParEfectivo);

                SqlParameter ParVuelto = new SqlParameter();
                ParVuelto.ParameterName = "@vuelto";
                ParVuelto.SqlDbType = SqlDbType.Decimal;
                ParVuelto.Value = Pagos.Vuelto;
                SqlCmd.Parameters.Add(ParVuelto);

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
        public string InsertarVenta(DPagos Ventas)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdv = new SqlParameter();
                ParIdv.ParameterName = "@idv";
                ParIdv.SqlDbType = SqlDbType.Int;
                ParIdv.Value = Ventas.Idv;
                SqlCmd.Parameters.Add(ParIdv);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Ventas.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

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
