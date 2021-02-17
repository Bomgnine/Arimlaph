using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCompras
    {
        public static string Insertar(string fecha, string nombre, string rif, string factura, string control,
             string maquina, double baseI, double impuesto, double total)
        {
            DCompras obj = new DCompras();

            obj.Fecha = fecha;
            obj.Nombre = nombre;
            obj.RIF = rif;
            obj.Factura = factura;
            obj.Control = control;
            obj.Maquina = maquina;
            obj.Base = baseI;
            obj.Impuesto = impuesto;
            obj.Total = total;

            return obj.Insertar(obj);
        }
        public static string Editar(int operacion, string fecha, string nombre, string rif, string factura, string control,
             string maquina, double baseI, double impuesto, double total)
        {
            DCompras obj = new DCompras();

            obj.Operacion = operacion;
            obj.Fecha = fecha;
            obj.Nombre = nombre;
            obj.RIF = rif;
            obj.Factura = factura;
            obj.Control = control;
            obj.Maquina = maquina;
            obj.Base = baseI;
            obj.Impuesto = impuesto;
            obj.Total = total;

            return obj.Editar(obj);
        }
        public static string Eliminar(int operacion)
        {
            DCompras obj = new DCompras();
            obj.Operacion = operacion;

            return obj.Eliminar(obj);
        }
        public static DataTable Buscar(string textobuscar)
        {
            DCompras obj = new DCompras();
            obj.TextoBuscar = textobuscar;

            return obj.Buscar(obj);
        }
        public static DataTable Mostrar()
        {
            return new DCompras().Mostrar();
        }
    }
}
