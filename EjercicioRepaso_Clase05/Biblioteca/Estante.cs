using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante) : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProducto()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("ESTANTE {0}\n", e.ubicacionEstante);

            foreach (Producto p1 in e.GetProducto())
            {
                if (!(p1 is null))
                {
                    sb.AppendFormat("\nPRODUCTO:\n{0}", Producto.MostrarProducto(p1));
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto pAux in e.GetProducto())
            {
                if (!(pAux is null) && pAux == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e.GetProducto().Length; i++)
                {
                    if (e.GetProducto()[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e.GetProducto().Length; i++)
                {
                    e.productos[i] = null;
                }
            }
            return e;
        }



    }
}
