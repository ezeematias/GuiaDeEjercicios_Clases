using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("MARCA: {0}\n", p.GetMarca());
            sb.AppendFormat("PRECIO: {0}\n", p.GetPrecio());
            sb.AppendFormat("COD: {0}\n", (string)p);

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.GetMarca() == p2.GetMarca() && (string)p1 == (string)p2);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.GetMarca() == p2.GetMarca() && (string)p1 == (string)p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            return (p.GetMarca() == marca);
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p.GetMarca() == marca);
        }


    }
}
