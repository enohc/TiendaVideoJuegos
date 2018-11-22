using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace renta_juegos.Models
{
    [Table("categoria")]
    public class Categoria
    {
        [Key]
        string cod_categoria { get; set; }
        string nombre { get; set; }
    }
}