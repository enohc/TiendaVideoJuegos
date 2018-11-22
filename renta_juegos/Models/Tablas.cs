using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace renta_juegos.Models
{
    public class Tablas : DbContext
    {
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Juego> juegos { get; set; }
        public DbSet<Renta> rentas { get; set; }
        public DbSet<Tipo> tipos { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        
    }
}