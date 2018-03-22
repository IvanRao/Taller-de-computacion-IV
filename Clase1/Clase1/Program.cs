using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            
            Console.WriteLine("Ingrese su opcion (del número 1 al 5 segun el ejercicio que quiera).");
            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    NombreYApellido();
                    break;
                case 2:
                    Edad();
                    break;
                case 3:
                    NumerosAnteriores();
                    break;
                case 4:
                    MDC();
                    break;
                case 5:
                    Promedio();
                    break;
                default:
                    Console.WriteLine("Ingrese bien la opcion");
                    Console.Read();
                    break;
            }

        }

        static void NombreYApellido()
        {
            //Realizar un programa de consola que permita ingresar el nombre y apellido por separado, con estos datos debe imprimir un mensaje con el nombre completo.

            String nombre;
            String apellido;

            Console.WriteLine("\nRealizar un programa de consola que permita ingresar el nombre y apellido por separado, \ncon estos datos debe imprimir un mensaje con el nombre completo. \n");
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido");
            apellido = Console.ReadLine();

            Console.WriteLine("Usted es " + nombre + " " + apellido);
            Console.Read();
        }

        static void Edad()
        {
            //Realizar un programa de consola que permita ingresar el nombre y la edad, con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.

            String nombre;
            int edad;

            Console.WriteLine("\nRealizar un programa de consola que permita ingresar el nombre y la edad, \ncon estos datos debe imprimir un mensaje diciendo si es mayor de edad o no. \n");
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine(nombre + " es mayor de edad.");
                Console.Read();
            }
            else
            {
                Console.WriteLine(nombre + " es menor de edad.");
                Console.Read();
            }
        }

        static void NumerosAnteriores()
        {
            //Realizar un programa de consola que permita ingresar un numero y calcule la suma de todos los numeros enteros anteriores.

            int num = 0;
            int resultado = 0;

            Console.WriteLine("\nRealizar un programa de consola que permita ingresar un numero y calcule \nla suma de todos los numeros enteros anteriores. \n");
            Console.WriteLine("Ingrese el número");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; num > i; i++)
            {
                resultado += +i;
            }

            Console.WriteLine("Resultado: " + resultado);
            Console.Read();
        }

        static void MDC()
        {
            //Realizar un programa de consola que permita ingresar 2 valores y encuentre el maximo comun divisor.

            int num1 = 0;
            int num2 = 0;
            int a = 0;
            int b = 0;
            int res = 0;

            Console.WriteLine("\nRealizar un programa de consola que permita ingresar 2 valores \ny encuentre el maximo comun divisor. \n");
            Console.WriteLine("Ingrese el primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = int.Parse(Console.ReadLine());

            a = Math.Max(num1, num2);
            b = Math.Min(num1, num2);

            do
            {
                res = b; // Guardamos el divisor en el resultado
                b = a % b; // Guardamos el resto en el divisor
                a = res; // El divisor pasa al dividendo
            } while (b != 0);

            Console.WriteLine("El MCD es : " + res);
            Console.Read();
        }

        static void Promedio()
        {
            //Realizar un programa de consola que permita ingresar numeros y que termine de pedir numeros cuando se ingresa 0 y calcule el promedio de todos los ingresados.

            double num = 0;
            double promedio = 0;
            List<double> numeros = new List<double>();

            Console.WriteLine("\nRealizar un programa de consola que permita ingresar numeros y que termine de pedir numeros \ncuando se ingresa 0 y calcule el promedio de todos los ingresados. \n");
            do
            {
                Console.WriteLine("Ingrese el número");
                num = int.Parse(Console.ReadLine());
                numeros.Add(num);
            } while (num != 0);

            if (numeros.Count > 1)
                promedio = numeros.Sum() / (numeros.Count - 1);
            else
                promedio = 0;

            Console.WriteLine("El promedio es : " + promedio);
            Console.Read();
        }


    }
}
