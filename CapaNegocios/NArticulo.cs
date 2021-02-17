﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NArticulo
    {
        public static string Insertar(string codigo, string nombre, string descripcion, byte[] imagen,
            int idcategoria, int idpresentacion, int inventario, double pcompra, double pventa, double pvpbs)
        {
            DArticulo Obj = new DArticulo();
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;
            Obj.Inventario = inventario;
            Obj.Pcompra = pcompra;
            Obj.Pventa = pventa;
            Obj.PVPbs = pvpbs;

            return Obj.Insertar(Obj);
        }
        public static string Editar(int idarticulo, string codigo, string nombre, string descripcion, byte[] imagen,
            int idcategoria, int idpresentacion, int inventario, double pcompra, double pventa, double pvpbs)
        {
            DArticulo Obj = new DArticulo();
            Obj.Idarticulo = idarticulo;
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Idcategoria = idcategoria;
            Obj.Idpresentacion = idpresentacion;
            Obj.Inventario = inventario;
            Obj.Pcompra = pcompra;
            Obj.Pventa = pventa;
            Obj.PVPbs = pvpbs;

            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idarticulo)
        {
            DArticulo Obj = new DArticulo();
            Obj.Idarticulo = idarticulo;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DArticulo().Mostrar();
        }
        public static DataTable BuscarNombre(string textobuscar)
        {
            DArticulo Obj = new DArticulo();
            Obj.TextoBuscar = textobuscar;

            return Obj.BuscarNombre(Obj);
        }
    }
}
