using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace renta_juegos.Models
{
    [Table("tipo")]
    public class Tipo
    {
        [Key]
        public string cod_tipo{ get; set; }
        public string nombre { get; set; }

    }
}