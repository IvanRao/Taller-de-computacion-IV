using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public abstract class FiguraGeometrica
    {
        public double Area;
        public double Perimetro;

        public virtual double CalcularArea()
        {
            return Area;
        }

        public virtual double CalcularPerimetro()
        {
            return Perimetro;
        }

        public virtual void MostrarResultado()
        {
            Console.WriteLine("\nLas Medidas son:\n*Perimetro = " + CalcularPerimetro() + "\n*Area = " + CalcularArea());
            Console.Read();
        }

    }
}
