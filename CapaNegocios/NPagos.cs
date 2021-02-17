using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NPagos
    {
        public static string Insertar(int idv, string fecha, double divisas, double debito, double pagomovil, double transferencia, double visa,
            double master, double efectivo, double vuelto)
        {
            DPagos obj = new DPagos();
            obj.Idv = idv;
            obj.Fecha = fecha;
            obj.Divisas = divisas;
            obj.Debito = debito;
            obj.Pagomovil = pagomovil;
            obj.Transferencia = transferencia;
            obj.Visa = visa;
            obj.Master = master;
            obj.Efectivo = efectivo;
            obj.Vuelto = vuelto;

            return obj.Insertar(obj);
        }

        public static string InsertarVenta(int idv, string fecha)
        {
            DPagos obj = new DPagos();
            obj.Idv = idv;
            obj.Fecha = fecha;

            return obj.InsertarVenta(obj);
        }
    }
}
