using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace renta_juegos.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        string dui { get; set; }
        string nombres { get; set; }
        string apellidos { get; set; }        
        DateTime fecha_afiliacion { get; set; }
        string email { get; set; }
        string telefono { get; set; }
    }
}