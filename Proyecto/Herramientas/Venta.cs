using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Proyecto.Herramientas
{
    public class Venta : DbContext
    {
        public Venta() : base("Venta")
        {
        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Factura> facturas { get; set; }
        public DbSet<Producto> productos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}