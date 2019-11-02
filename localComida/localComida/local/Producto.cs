using System;
using System.Collections.Generic;
using System.Text;

namespace localComida.local
{
    public class Producto
    {
        public Producto(int codigo, string descripcion, double precio, List<ProductosyFacturas> productosYFacturas)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            ProductosYFacturas = productosYFacturas;
        }
        public Producto() { }
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private List<ProductosyFacturas> productosYfacturas;
        public List<ProductosyFacturas> ProductosYFacturas 
        {
            get { return productosYfacturas; }
            set { productosYfacturas = value; }
        }

        public int Cantidad { get; internal set; }
    }
}
