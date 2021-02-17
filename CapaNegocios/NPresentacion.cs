using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPresentacion
    {
        public static string Insertar(string sigla, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Sigla = sigla;
            Obj.Descripcion = descripcion;

            return Obj.Insertar(Obj);
        }
        public static string Editar(int idpresentacion, string sigla, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;
            Obj.Sigla = sigla;
            Obj.Descripcion = descripcion;

            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idpresentacion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new CapaDatos.DPresentacion().Mostrar();
        }
        public static DataTable BuscarNombre(string textobuscar)
        {
            CapaDatos.DPresentacion Obj = new DPresentacion();
            Obj.TextoBuscar = textobuscar;

            return Obj.BuscarNombre(Obj);
        }
    }
}
