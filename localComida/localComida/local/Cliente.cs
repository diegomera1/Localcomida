using System;
using System.Collections.Generic;
using System.Text;

namespace localComida.local
{
    public class Cliente
    {
        public Cliente(string nombre, string identificacion, int telefono, string direccion, List<Factura> facturas)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Telefono = telefono;
            Direccion = direccion;
            Facturas = facturas;
        }

        public Cliente() { }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        private List<Factura> facturas;

  

        public List<Factura> Facturas
        {
            get { return facturas; }
            set { facturas = value; }
        }



    }
}
