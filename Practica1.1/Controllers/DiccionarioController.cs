using Practica1._1.Models;
using Practica1._1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1._1.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
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

                        if (partes[0].Trim().ToLower() == word.Search.ToLower())
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
