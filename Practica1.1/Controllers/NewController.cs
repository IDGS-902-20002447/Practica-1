using Practica1._1.Models;
using Practica1._1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1._1.Controllers
{
    public class NewController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult New()
        {
            ViewBag.Message = "Hello world.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Pasar los parametros y su tipos
        public ActionResult OperasBas(string n1,string n2,string opc)
        {
            
            
            if (opc == "suma")
            {
                int res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            if (opc == "resta")
            {
                int res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            if (opc == "multi")
            {
                int res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            if (opc == "div")
            {
                int res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }


            return View();
        }
        public ActionResult OperasBas2(Calculos op)
        {

           var model = new Calculos();
           model.Res = op.Num1 + op.Num2;

            ViewBag.Res = model.Res;
           return View(model);
        }

        public ActionResult Distancia(Distancia puntos)
        {
            var model = new Distancia();
            model.ResDistancia = puntos.Distances(puntos.x2,puntos.x1,puntos.y2,puntos.y1);

         
            return View(model);
        }

        public ActionResult MuestraPulques()
        {
            var pulques1=new PulquesServices();
            var model = pulques1.ObtenerPulque();

             return View(model);
        }
        public ActionResult MuestraPulques2()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();

            return View(model);
        }
    }
}