using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NMermatipo
    {
        public static string Insertar(string nombre, string descripcion)
        {
            DMermatipo obj = new DMermatipo();
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return obj.Insertar(obj);
        }
        public static string Editar(int id, string nombre, string descripcion)
        {
            DMermatipo obj = new DMermatipo();
            obj.Id = id;
            obj.Nombre = nombre;
            obj.Descripcion = descripcion;
            return obj.Editar(obj);
        }
        public static string Eliminar(int id)
        {
            DMermatipo obj = new DMermatipo();
            obj.Id = id;
            return obj.Eliminar(obj);
        }
        public static DataTable Mostrar()
        {
            return new CapaDatos.DMermatipo().Mostrar();
        }
    }
}
