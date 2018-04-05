using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Circulo:FiguraGeometrica
    {
        public double radio;
        public double pi = 3.14;

        public override double CalcularArea()
        {
            Area = pi * (radio * radio) ;
            return this.Area;
        }

        public override double CalcularPerimetro()
        {
            Perimetro = 2 * pi * radio;
            return this.Perimetro;
        }
    }
}
