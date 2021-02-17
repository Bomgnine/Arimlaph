using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NFacturas
    {
        public static string Insertar(int nfactura, int ncontrol, string fecha, string nombre, string cedula, string telefono,
            string direccion, double subtotal, double iva, double exento, double total, double totaldolares)
        {
            DFacturas obj = new DFacturas();
            obj.Nfactura = nfactura;
            obj.NControl = ncontrol;
            obj.Fecha = fecha;
            obj.Nombre = nombre;
            obj.Cedula = cedula;
            obj.Telefono = telefono;
            obj.Direccion = direccion;
            obj.SubTotal = subtotal;
            obj.IVA = iva;
            obj.Exento = exento;
            obj.Total = total;
            obj.TotalDolares = totaldolares;

            return obj.Insertar(obj);
        }
        public static string Eliminar(int idv)
        {
            DFacturas obj = new DFacturas();
            obj.Idv = idv;

            return obj.Eliminar(obj);
        }
        public static DataTable Buscar(int idv)
        {
            DFacturas obj = new DFacturas();
            obj.Idv = idv;

            return obj.Buscar(obj);
        }
        public static DataTable Mostrar()
        {
            return new DFacturas().Mostrar();
        }
    }
}
