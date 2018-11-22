using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace renta_juegos.Models
{
    public class Usuario
    {
        string usuario { get; set; }
        string clave { get; set; }
    }
}