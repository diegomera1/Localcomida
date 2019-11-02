using System;
using System.Collections.Generic;
using System.Text;

namespace localComida.local
{
    public class ProductosyFacturas
    {
        
        public ProductosyFacturas(Producto producto, int cantidad, double precio, Factura factura)
        {
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            Factura = factura;
        }
        public ProductosyFacturas() { }

        private Producto producto;
        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        private Factura factura;

        

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }

        public double Subtotal
        {
            get { return Cantidad*Precio; }
        }


        public override string ToString()
        {
            return this.Producto.Codigo+ "        |" + this.Producto.Descripcion+ "              |" + this.Cantidad+ "        |" +this.Precio+ "             |"+this.Subtotal;
        }
    }
}
