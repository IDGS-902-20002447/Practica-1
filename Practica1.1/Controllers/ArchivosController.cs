using Practica1._1.Models;
using Practica1._1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1._1.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Registrar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Registrar(Maestros maes)
        {
            var ope1 = new GuardaService();
            ope1.GuardarArchivos(maes);

            return View(maes);
        }
        public ActionResult LeerDatos()
        {
            var arch = new LeerService();
            ViewBag.Archivos = arch.LeerArchivo();
            return View();
        }

        /*Actividad del diccionario*/

        public ActionResult Diccionario()
        {
            return View();
        }

        public ActionResult ReadWord()
        {
            var arch = new ReadService();
            ViewBag.Archivos = arch.ReadWords();
            return View("Diccionario");
        }

        [HttpPost]
        public ActionResult Diccionario(Diccionario word)
        {
            var ope1 = new SaveWord();
            ope1.Save(word);

            return View(word);
        }

        public ActionResult SearchWord(Diccionario word)
        {
            string resp = "";
            var arch = new ReadService();
            var palabras = arch.ReadWords();
            

            if (palabras != null)
            {
                foreach (var palabra in palabras)
                {
                    var partes = palabra.ToString().Split(',');
                    if (word.Translate == "Spanish")
                    {
                       
                        if ( partes[0].Trim().ToLower() == word.Search.ToLower())
                        {
                            resp = partes[1].Trim();
                           
                            break; 
                        }
                        else
                        {
                            resp = "No se encontró la palabra ";
                        }
                    }
                    else if (word.Translate == "English")
                    {
                        if (partes[1].Trim().ToLower() == word.Search.ToLower())
                        {
                            resp = partes[0].Trim();
                            
                            break; 
                        }
                        else
                        {
                            resp = "No se encontró la palabra ";
                        }
                    }
                }
            }

          

            ViewBag.Search = word.Search;
            ViewBag.SearchWord = resp;
            return View();
        }


    }
}