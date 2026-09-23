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
    }
}
