using Practica1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica1._1.Services
{
    public class PulquesServices
    {
        public List<Pulques> ObtenerPulque()
        {
            var pulque1 = new Pulques()
            {
                Producto = "Pulque1",
                Descripcion = "Mango Piña",
                Litros = 20,
                Creacion = new DateTime(2023, 11, 5)
            };
            var pulque2 = new Pulques()
            {
                Producto = "Pulque2",
                Descripcion = "Mango Piña",
                Litros = 20,
                Creacion = new DateTime(2023, 11, 5)
            };

            return new List<Pulques>() { pulque1,pulque2};
        }
    }
}