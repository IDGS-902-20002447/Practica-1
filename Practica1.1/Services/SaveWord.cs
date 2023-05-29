using Practica1._1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Practica1._1.Services
{
    public class SaveWord
    {
        public void Save(Diccionario word)
        {
            var wordSpanish = word.WordSpanish.ToLower();
            var wordEnglish = word.WordEnglish.ToLower();
        
            var datos = wordSpanish + "," + wordEnglish+Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/dictionary.txt");

            File.AppendAllText(archivo, datos);

        }
    }
}