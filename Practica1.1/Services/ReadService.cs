using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Practica1._1.Services
{
    public class ReadService
    {
        public Array ReadWords()
        {
            Array wordDatos= null;
            var datos=HttpContext.Current.Server.MapPath("~/App_Data/dictionary.txt");
            if (File.Exists(datos))
            {
                wordDatos = File.ReadAllLines(datos); 
            }
            return wordDatos;
        }
    }
}