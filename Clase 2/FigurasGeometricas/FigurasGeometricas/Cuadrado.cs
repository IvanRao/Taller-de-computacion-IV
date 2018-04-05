using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasGeometricas;

namespace FigurasGeometricas
{
    public class Cuadrado:FiguraGeometrica
    {
        public double lado;

        public override double CalcularArea()
        {
            Area = lado * lado;
            return this.Area;
        }

        public override double CalcularPerimetro()
        {
            Perimetro = lado * 4;
            return this.Perimetro;
        }

    }
}
