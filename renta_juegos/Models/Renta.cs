using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace renta_juegos.Models
{
    [Table("renta")]
    public class Renta
    {
        string cod_renta { get; set; }
        string cod_juego { get; set; }
        string dui { get; set; }
        DateTime fecha_renta { get; set; }
        string fecha_devolucion { get; set; }
        string cobro { get; set; }
        string mora { get; set; }
    }
}