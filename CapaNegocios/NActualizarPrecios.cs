using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NActualizarPrecios
    {
        public static string ActualizarPrecios(double precio)
        {
            DActualizarPrecios obj = new DActualizarPrecios();
            obj.Preciodolar = precio;

            return obj.Actualizar(obj);
        }
    }
}
