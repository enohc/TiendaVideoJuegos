using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using renta_juegos.Models;

namespace renta_juegos.Controllers
{
    public class EmpleadoController : Controller
    {
        public ActionResult Index()
        {
            Tablas t = new Tablas();
            List<Tipo> tipo = t.tipos.ToList();

            return View(tipo);
        }

        public ActionResult Detalle(string id)
        {
            Tablas t = new Tablas();
            Tipo empleado = t.tipos.Single(tipo =>
            tipo.cod_tipo == id);

            return View(empleado);
        }
    }
}