using Practica1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Practica1._1.Models
{
    public class Distancia
    {
        //Distancia
        public float x1 { get; set; }
        public float x2 { get; set; }
        public float y1 { get; set; }
        public float y2 { get; set; }
        public double ResDistancia { get; set; }


        public double Distances(float x1, float x2, float y1, float y2)
        {
             ResDistancia =
                    Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2));
            return ResDistancia;
        }
        // d=√((x_2-x_1)²+(y_2-y_1)²)
    }

}