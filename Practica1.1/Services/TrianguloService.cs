using Practica1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica1._1.Services
{
    public class TrianguloService
    {
        public Triangulo ValidarTriangulo(double ax, double ay, double bx, double by, double cx, double cy)
        {
            double lado1 = Math.Round(Distancia(ax, ay, bx, by), 2);
            double lado2 = Math.Round(Distancia(bx, by, cx, cy), 2);
            double lado3 = Math.Round(Distancia(cx, cy, ax, ay), 2);
          
            Triangulo triangulo = new Triangulo
            {
                ax = ax,
                ay = ay,
                bx = bx,
                by = by,
                cx = cx,
                cy = cy,
            };

            triangulo.validar = (lado1 + lado2 > lado3) && (lado2 + lado3 > lado1) && (lado3 + lado1 > lado2);
            if (triangulo.validar)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    triangulo.Tipo = "Equilátero. Lados:\nLado 1: " + lado1 + "\nLado 2: " + lado2 + "\nLado 3: " + lado3;
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                {
                    triangulo.Tipo = "Isósceles. Lados:\nLado 1: " + lado1 + "\nLado 2: " + lado2 + "\nLado 3: " + lado3;
                }
                else
                {
                    triangulo.Tipo = "Escaleno. Lados:\nLado 1: " + lado1 + "\nLado 2: " + lado2 + "\nLado 3: " + lado3;
                }


                triangulo.Perimetro = lado1 + lado2 + lado3;
                
                /*---------------------------------------------------*/
                double semiperimetro = triangulo.Perimetro / 2;
                double resultado = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

                triangulo.Area = resultado;

               

            }

            return triangulo;
        }

        private double Distancia(double x1, double y1, double x2, double y2)
        {
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distancia;
        }


    }


}



/*


var tolerancia = .01;
if ((lado1 - lado2) < tolerancia && (lado2 - lado3) < tolerancia && (lado3 - lado1) < tolerancia)
{
    triangulo.Tipo = "Equilátero. Lados:\nLado 1: " + lado1 + "\nLado 2: " + lado2 + "\nLado 3: " + lado3;
}
else if ((lado1 - lado2) < tolerancia || (lado2 - lado3) < tolerancia || (lado3 - lado1) < tolerancia)
{
    triangulo.Tipo = "Isósceles. Lados:\nLado 1: " + lado1 + "\nLado 2: " + lado2 + "\nLado 3: " + lado3;
}
else
{
    triangulo.Tipo = "Escaleno. Lados:\nLado 1: " + lado1 + "\nLado 2: " + lado2 + "\nLado 3: " + lado3;
}
*/