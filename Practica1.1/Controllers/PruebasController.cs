using Practica1._1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1._1.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public JsonResult Index()
        {
            var idgs902 = new Alumnos()
            {
                Name = "Mario",
                Email = "mario@gmail.com",
                Edad = 23
            };

            return Json(idgs902, JsonRequestBehavior.AllowGet
                );
        }


        public RedirectResult Index2()
        {
            return Redirect("Index");
        }

        public RedirectToRouteResult Index3()
        {
            return RedirectToAction("OperasBas", "New");
        }
        /*for (int i = 0; i < Convert.ToInt16(numero.Length); i++)
           {
               sum += numero[i];
           }*/

        //  int[] frequencia = new int[10];
        public ActionResult Index4()
        {
            ViewBag.Grupo = "IDGS902";
            ViewBag.Numero = 20;
            ViewBag.FechaInicio = new DateTime(2023, 2, 5);
            ViewData["Nombre"] = "Mario";

            return View();
        }
        public ActionResult CajasDinamicas(string NumEntrada)
        {

            ViewBag.Numero = Convert.ToInt16(NumEntrada);
            return View();
        }
        public ActionResult Resultado(string NumEntrada, int[] numero)
        {
            int sum = 0;
           
            Dictionary<int, int> frequencia = new Dictionary<int, int>();

            for (int i = 0; i < Convert.ToInt32(numero.Length); i++)
            {
                sum += numero[i];
                int num = numero[i];
                if (frequencia.ContainsKey(num))
                {
                    frequencia[num]++;
                }
                else
                {
                    frequencia[num] = 1;
                }
            }

            ViewBag.Sum = sum;
           
            @ViewBag.Frecuencia = frequencia;
            return View("CajasDinamicas");
        }

    }
}
