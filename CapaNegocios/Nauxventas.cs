using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NAuxventas
    {
        public static string Insertar(string codigo)
        {
            DAuxventas obj = new DAuxventas();
            obj.Codigo = codigo;
            return obj.Insertar(obj);
        }
        public static string Editar(int id, int cantidad)
        {
            DAuxventas obj = new DAuxventas();
            obj.Id = id;
            obj.Cantidad = cantidad;
            return obj.Editar(obj);
        }
        public static string Eliminar(int id)
        {
            DAuxventas obj = new DAuxventas();
            obj.Id = id;
            return obj.Eliminar(obj);
        }
        public static string Borrar()
        {
            return new DAuxventas().Borrar();
        }
        public static DataTable Mostrar()
        {
            return new DAuxventas().Mostrar();
        }
        public static string Idv()
        {
            return new DAuxventas().IdV();
        }
        public static string ActualizarInventario()
        {
            return new DAuxventas().ActualizarInventario();
        }
    }
}
