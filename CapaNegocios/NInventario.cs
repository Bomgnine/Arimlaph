using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NInventario
    {
        public static DataTable MostrarInventario()
        {
            return new CapaDatos.DInventario().MostrarInventario();
        }
        public static DataTable BuscarInventario(string codigo)
        {
            DInventario obj = new DInventario();
            obj.Codigo = codigo;

            return obj.BuscarInventario(obj);
        }
        public static string EditarInventario(string codigo, int inventario, double pcompra, double pventa)
        {
            DInventario obj = new DInventario();
            obj.Codigo = codigo;
            obj.Inventario = inventario;
            obj.Pcompra = pcompra;
            obj.Pventa = pventa;

            return obj.EditarInventario(obj);
        }
    }
}
