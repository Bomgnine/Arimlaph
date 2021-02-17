using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NMerma
    {
        public static string Insertar(string fecha, string tipomerma)
        {
            DMerma obj = new DMerma();
            obj.Fecha = fecha;
            obj.TipoMerma = tipomerma;

            return obj.Isertar(obj);
        }
    }
}
