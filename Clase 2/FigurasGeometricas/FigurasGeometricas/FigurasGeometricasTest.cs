using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class FigurasGeometricasTest
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            Console.WriteLine("Ingrese su opcion (1-Cuadrado/2-Triangulo/3-Circulo).");
            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    EjecutarCuadrado();
                    break;
                case 2:
                    EjecutarTriangulo();
                    break;
                case 3:
                    EjecutarCirculo();
                    break;
                default:
                    Console.WriteLine("Ingrese bien la opcion");
                    Console.Read();
                    break;
            }

        }

        static public void EjecutarCuadrado()
        {
            Cuadrado Cua = new Cuadrado();

            Console.WriteLine("\nIngrese la medida del lado");
            double.TryParse(Console.ReadLine(), out Cua.lado);

            Imprimir(Cua);
        }

        static public void EjecutarTriangulo()
        {
            Triangulo Tri = new Triangulo();

            Console.WriteLine("\nIngrese la medida del lado");
            double.TryParse(Console.ReadLine(), out Tri.lado);

            Imprimir(Tri);
        }

        static public void EjecutarCirculo()
        {
            Circulo Cir = new Circulo();

            Console.WriteLine("\nIngrese la medida del radio");
            double.TryParse(Console.ReadLine(), out Cir.radio);

            Imprimir(Cir);
        }

        static public void Imprimir(FiguraGeometrica Figura)
        {
            Figura.MostrarResultado();
        }

    }
}
