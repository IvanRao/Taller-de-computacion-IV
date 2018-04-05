using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Triangulo:FiguraGeometrica
    {
        public double lado;

        public override double CalcularArea()
        {
            Area = (lado * lado) / 2;
            return this.Area;
        }

        public override double CalcularPerimetro()
        {
            Perimetro = lado * 3;
            return this.Perimetro;
        }


    }
}
