using System;
using System.Collections.Generic;
using localComida.local;
namespace localComida
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primera Factura
            List<Factura> listaDeFacturas = new List<Factura>();
            List<ProductosyFacturas> listaDeProductos1 = new List<ProductosyFacturas>();
            listaDeProductos1.Add(
                new ProductosyFacturas()
                {
                    Producto = new Producto()
                    {
                        Codigo = 1,
                        Descripcion = "Hamburguesa",
                        Precio = 10,
                    },
                    Cantidad = 5,
                    Precio = 10
                });
            listaDeProductos1.Add(
              new ProductosyFacturas()
              {
                  Producto = new Producto()
                  {
                      Codigo = 2,
                      Descripcion = "Atún",
                      Precio = 10,
                  },
                  Cantidad = 2,
                  Precio = 10
              });
            listaDeProductos1.Add(
              new ProductosyFacturas()
              {
                  Producto = new Producto()
                  {
                      Codigo = 3,
                      Descripcion = "Doritos",
                      Precio = 1,
                  },
                  Cantidad = 5,
                  Precio = 1
              });
            listaDeFacturas.Add(
                new Factura()
                {

                    NUmeroDeFactura = 1,
                    Fecha = "31-10-2019",
                    ProductosYFacturas = listaDeProductos1,
                    Cliente = new Cliente()
                    {
                        Nombre = "Cristhian Jossué Bacusoy Holguín",
                        Identificacion = "1317165270",
                        Telefono = 0998765321,
                        Direccion = "Calle Primero de Enero y  Guillermo Balda"
                    },
                    Descuento = 0.1
                }
                );
            
            //Segunda Factura
            List<ProductosyFacturas> listaDeProductos2 = new List<ProductosyFacturas>();
            listaDeProductos2.Add(
                new ProductosyFacturas()
                {
                    Producto = new Producto()
                    {
                        Codigo = 1,
                        Descripcion = "Carne",
                        Precio = 1.5,
                    },
                    Cantidad = 4,
                    Precio = 1.5,
                });
            listaDeProductos2.Add(
                new ProductosyFacturas()
                {
                    Producto = new Producto()
                    {
                        Codigo = 2,
                        Descripcion = "Huevo",
                        Precio = 3,
                    },

                    Cantidad = 2,
                    Precio = 3,
                });
            listaDeProductos2.Add(
                new ProductosyFacturas()
                {
                    Producto = new Producto()
                    {
                        Codigo = 3,
                        Descripcion = "Agua",
                        Precio = 1,
                    },
                    Cantidad = 5,
                    Precio = 1,
                });
            listaDeFacturas.Add(
                new Factura()
                {

                    NUmeroDeFactura = 2,
                    Fecha = "31-10-2019",
                    ProductosYFacturas = listaDeProductos2,

                    Cliente = new Cliente()
                    {
                        Nombre = "Ducan Dhu",
                        Identificacion = "2005",
                        Telefono = 09999,
                        Direccion = "En algún lugar de un gran país",

                    },
                    Descuento = 0.01

                });
            //Tercera Factura
            List<ProductosyFacturas> listaDeProductos3 = new List<ProductosyFacturas>();
            listaDeProductos3.Add(
                    new ProductosyFacturas()
                    {
                        Producto = new Producto()
                        {
                            Codigo = 1,
                            Descripcion = "Carne de Res",
                            Precio = 4,
                        },
                        Cantidad = 2,
                        Precio = 4
                    });
            listaDeProductos3.Add(
            new ProductosyFacturas()
            {
                Producto = new Producto()
                {
                    Codigo = 2,
                    Descripcion = "Chuletas",
                    Precio = 5,
                },
                Cantidad = 5,
                Precio = 5
            });
            listaDeProductos3.Add(
             new ProductosyFacturas()
             {
                 Producto = new Producto()
                 {
                     Codigo = 3,
                     Descripcion = "Pollo",
                     Precio = 3,
                 },
                 Cantidad = 1,
                 Precio = 3
             });
            listaDeFacturas.Add(
                new Factura()
                {

                    NUmeroDeFactura = 3,
                    Fecha = "01-11-2019",
                    ProductosYFacturas = listaDeProductos3,
                    Cliente = new Cliente()
                    {
                        Nombre = "Jose Jose Estrella",
                        Identificacion = "215717985",
                        Telefono = 1999,
                        Direccion = "Japón Calle Oda"
                    },
                    Descuento = 0.2
                }
                );
            //Imprimir
            Console.WriteLine("----------------------------------------------------------------------------------");
            foreach (Factura item in listaDeFacturas)
            {
                Console.WriteLine("Número de factura:" + item.NUmeroDeFactura);
                Console.WriteLine("Cliente: "+item.Cliente.Nombre);
                Console.WriteLine("Código   |    Descripción   |  Cantidad    |    Precio   |   Subtotal");
                foreach (ProductosyFacturas item2 in item.ProductosYFacturas)
                {
                    Console.WriteLine(item2.ToString());
                }
                Console.WriteLine(item.ToString());
                Console.WriteLine("----------------------------------------------------------------------------------");
            }
                    
        }
    }
}
