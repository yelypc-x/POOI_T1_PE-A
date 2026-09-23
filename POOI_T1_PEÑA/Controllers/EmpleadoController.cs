using POOI_T1_PEÑA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOI_T1_PEÑA.Controllers
{
    public class EmpleadoController : Controller
    {

        //get
        public ActionResult RegistrarEmpleado()
        {
            Empleado emp = new Empleado();
            ViewBag.Enviado = false;
            return View(emp);
        }


        //post
        [HttpPost]
        public ActionResult RegistrarEmpleado(Empleado emp)
        {
            ViewBag.Enviado = true;
            return View(emp);
        }

        public ActionResult RegistrarAdministrativo()
        {
            Administrativo admin = new Administrativo();
            return View(admin);
        }

        [HttpPost]
        public ActionResult RegistrarAdministrativo(Administrativo admin)
        {
            return View(admin);
        }



        public static List<Empleado> Planilla = new List<Empleado>
        {
            new Empleado { idEmpleado = "001", nomapeEmpleado = "Fernando Rios", categoriaEmpleado = "E1", nHijos = 2, tipoContrato = "Indefinido" },
            new Empleado { idEmpleado = "002", nomapeEmpleado = "Ana Chavarria", categoriaEmpleado = "E2", nHijos = 1, tipoContrato = "Contratado" },
            new Empleado { idEmpleado = "003", nomapeEmpleado = "Carlos Campos", categoriaEmpleado = "E3", nHijos = 0, tipoContrato = "Indefinido" },
            new Empleado { idEmpleado = "004", nomapeEmpleado = "Lupe Vara", categoriaEmpleado = "E1", nHijos = 4, tipoContrato = "Contratado" }
        };

        // GET
        public ActionResult Index()
        {
            return View(Planilla);
        }

        // GET
        public ActionResult Agregar()
        {
            Empleado emp = new Empleado();
            return View(emp);
        }

        // POST:
        [HttpPost]
        public ActionResult Agregar(Empleado emp)
        {
            bool existe = Planilla.Any(e => e.idEmpleado == emp.idEmpleado);

            if (existe)
            {
                ViewBag.Mensaje = "Error: el ID de Empleado ya existe.";
            }
            else
            {
                Planilla.Add(emp);
                ViewBag.Mensaje = "Empleado guardado correctamente.";
            }

            return View(emp);
        }
    }
}
