using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data; 

namespace CapaNegocio
{
    public class NUsuarios
    {
        public static string Insertar(string usuario, string contraseña, string nivel)
        {
            DUsuarios obj = new DUsuarios();
            obj.Usuario = usuario;
            obj.Contraseña = contraseña;
            obj.Nivel = nivel;

            return obj.Insertar(obj);
        }
        public static string Editar(int id, string usuario, string contraseña, string nivel)
        {
            DUsuarios obj = new DUsuarios();
            obj.Id = id;
            obj.Usuario = usuario;
            obj.Contraseña = contraseña;
            obj.Nivel = nivel;

            return obj.Editar(obj);
        }
        public static string Eliminar(int id)
        {
            DUsuarios obj = new DUsuarios();
            obj.Id = id;

            return obj.Eliminar(obj);
        }
        public static DataTable Mostrar()
        {
            return new CapaDatos.DUsuarios().Mostrar();
        }
        public static string Login(string usuario, string contraseña)
        {
            DUsuarios obj = new DUsuarios();
            obj.Usuario = usuario;
            obj.Contraseña = contraseña;

            return obj.Login(obj);
        }
    }
}
