﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    public class CostCalculator
    {
        public CostCalculator() { }

        public double CalcularAreaBaldosaCuadrada(Baldosa baldosa)
        {
            if (baldosa.Tipo != "Cuadrada")
            {
                throw new ArgumentException("La baldosa no es cuadrada.");
            }

            double lado = baldosa.Lado;
            double area = lado * lado;
            return area;
        }

        public double CalcularAreaBaldosaCircular(Baldosa baldosa)
        {
            if (baldosa.Tipo != "Circular")
            {
                throw new ArgumentException("La baldosa no es circular.");
            }

            double radio = baldosa.Lado / 2.0; 
            double area = Math.PI * Math.Pow(radio, 2);
            Math.Round(area);
            return area;
        }

        public double CalcularCostoTotal(List<Baldosa> baldosas, double precioPorMetroCuadrado)
        {
            double costoTotal = 0.0;
            double area;
            double precioMaterial = 0.0;
            foreach (var baldosa in baldosas)
            {

                if (baldosa.Material == "Cemento")
                {
                    precioMaterial = 5.0;
                }

                if(baldosa.Material == "Ladrillo")
                {
                    precioMaterial = 10.0;
                }

                if (baldosa.Tipo =="Cuadrada")
                {
                    area = CalcularAreaBaldosaCuadrada(baldosa);
                }
                else if((baldosa.Tipo == "Circular"))
                {
                    area = CalcularAreaBaldosaCircular(baldosa);
                }
                else
                {
                    throw new ArgumentException("Tipo de baldosa no válido.");
                }
                double costoParcial = (area * precioMaterial);
                costoTotal += costoParcial;
            }
            return costoTotal;
        }
    }
}
