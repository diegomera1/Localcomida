using System;
using System.Collections.Generic;
using System.Text;

namespace localComida.local
{
    public class Factura
    {
        public Factura(int nUmeroDeFactura, String fecha, List<ProductosyFacturas> productosYFacturas, Cliente cliente, double descuento)
        {
            NUmeroDeFactura = nUmeroDeFactura;
            Fecha = fecha;
            ProductosYFacturas = productosYFacturas;
            Cliente = cliente;
            Descuento = descuento;
        }
        public Factura() { }

        private int nUmeroFactura;

        public int NUmeroDeFactura
        {
            get { return nUmeroFactura; }
            set { nUmeroFactura = value; }
        }
        private String fecha;

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private List<ProductosyFacturas> productosYfacturas;

        public List<ProductosyFacturas> ProductosYFacturas
        {
            get { return productosYfacturas; }
            set {
                if (value.Count < 1 || value.Count > 20)
                {
                    throw new Exception("Lista mayor a 20");
                }
                productosYfacturas = value; 
            }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private double descuento;

       

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public double Subtotal
        {
            get 
            {

                double subtotal = 0;
                foreach (ProductosyFacturas item in this.ProductosYFacturas)
                {
                    subtotal += item.Subtotal;
                }
                return subtotal;
            
            }

        }

        public double ImprimirDescuento
        {
            get { return Subtotal*Descuento; }
        }

        public double SubtotalDescuento
        {
            get { return Subtotal*(1-Descuento); }
        }
        
        public double Iva
        {
            get { return SubtotalDescuento*0.12; }
        }

        public double Total
        {
            get { return SubtotalDescuento+Iva; }
        }
        public override string ToString()
        {
            return "Subtotal: "+this.Subtotal+"\n"+"Descuento: "+this.ImprimirDescuento+"\n"+"Subtotal-Descuento: "+this.SubtotalDescuento+"\n"+"Iva:"+this.Iva+"\n"+"Total:"+this.Total;
        }
    }
}
