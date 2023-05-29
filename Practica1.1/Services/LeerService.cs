﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Practica1._1.Services
{
    public class LeerService
    {
        public Array LeerArchivo()
        {
            Array maesDatos= null;
            var datos=HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(datos))
            {
                maesDatos=File.ReadAllLines(datos); 
            }
            return maesDatos;
        }
    }
}