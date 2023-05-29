using Practica1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1._1.Controllers
{
    public class Pruebas2Controller : Controller
    {
        // GET: Pruebas2
        public ActionResult Index()
        {
            var alumno = new Alumnos() 
            {
                Name="Jimena",
                Edad=28,
                Email="jimena@gmail.com",
                Activo=false,
                Inscripcion=new DateTime(2023,4,20)
            };

            ViewBag.Alumnos = alumno;

            return View();
        }
        public ActionResult Escuela()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Edad = 28,
                Email = "jimena@gmail.com",
                Activo = false,
                Inscripcion = new DateTime(2023, 4, 20)
            };


            ViewBag.Alumnos = alumno;

            return View(alumno);
        }
    }
}