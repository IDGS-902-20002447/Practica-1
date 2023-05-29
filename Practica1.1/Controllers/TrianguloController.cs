using Practica1._1.Models;
using Practica1._1.Services;
using System.Web.Mvc;

namespace Practica1._1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
  
            public ActionResult Index(Triangulo triangulo)
        {
            var Service = new TrianguloService();

            
           Triangulo resultado = Service.ValidarTriangulo(triangulo.ax, triangulo.ay, triangulo.bx, triangulo.by, triangulo.cx, triangulo.cy);

               
                ViewBag.Respuesta = resultado.validar;
                ViewBag.Tipo = "Tipo de triángulo: " + resultado.Tipo;
                ViewBag.Area = "Área: " + resultado.Area;
                ViewBag.Perimetro = "Perímetro: " + resultado.Perimetro;
            

            return View();
        }
    }
}