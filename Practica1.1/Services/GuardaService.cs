using Practica1._1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Practica1._1.Services
{
    public class GuardaService
    {
        public void GuardarArchivos(Maestros maes)
        {
            var nombre = maes.Nombre;
            var apePaterno = maes.ApePaterno;
            var apeMaterno = maes.ApeMaterno;
            var edad = maes.Edad;
            var email = maes.Email;

            var datos=nombre+","+apePaterno+","+apeMaterno+","+edad+","+email+
                Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            
            File.AppendAllText(archivo, datos); 

        }
    }
}