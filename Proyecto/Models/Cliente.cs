using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Capture el apellido del cliente")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Capture el nombre del cliente")]
        public string Nombre { get; set; }
    }
}