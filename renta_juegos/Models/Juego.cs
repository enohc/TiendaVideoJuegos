using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace renta_juegos.Models
{
    [Table("juego")]
    public class Juego
    {
        [Key]
        string cod_juego { get; set; }
        string nombre { get; set; }
        string cod_tipo { get; set; }
        string cod_categoria { get; set; }
        DateTime fecha_ingreso { get; set; }
        int disponibles { get; set; }
        string caratula { get; set; }
    }
}