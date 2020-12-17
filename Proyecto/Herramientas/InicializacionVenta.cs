using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Proyecto.Models;

namespace Proyecto.Herramientas
{
    public class InicializacionVenta: System.Data.Entity.DropCreateDatabaseIfModelChanges<Venta>
    {
        protected override void Seed(Venta context)
        {
            var clientes1 = new List<Cliente>
            {
                new Cliente{ClienteId=1,Apellidos="Perez",Nombre="Manolo"},
                new Cliente{ClienteId=2,Apellidos="Rosalia",Nombre="Juan"},
                new Cliente{ClienteId=3,Apellidos="Dominguez",Nombre="Alma"}
            };
            clientes1.ForEach(s => context.clientes.Add(s));
            context.SaveChanges();
            var facturas1 = new List<Factura>
            {
                new Factura{FacturaId=1,ImporteTotal=200.00,FechaDeImporte="3/10/2000"},
                new Factura{FacturaId=2,ImporteTotal=800.25,FechaDeImporte="11/5/2007"},
                new Factura{FacturaId=3,ImporteTotal=350.25,FechaDeImporte="1/6/2007"}
            };
            facturas1.ForEach(s => context.facturas.Add(s));
            context.SaveChanges();
            var productos1 = new List<Producto>
            {
                new Producto{ProductoId=1,NombreProducto="Manzana",Precio=5.00},
                new Producto{ProductoId=2,NombreProducto="Bisteck del 7", Precio=80.00},
                new Producto{ProductoId=3,NombreProducto="Pimienta negra molida",Precio=3.00}
            };
            productos1.ForEach(s => context.productos.Add(s));
            context.SaveChanges();
        }
    }
}