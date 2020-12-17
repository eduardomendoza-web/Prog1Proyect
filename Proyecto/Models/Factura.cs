using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public double ImporteTotal { get; set; }
        public string FechaDeImporte { get; set; }
        public ICollection<Cliente> cliente { get; set; }
    }
}