using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E26_Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese algun número");
                if(Int32.TryParse(Console.ReadLine(), out int n))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    ImprimirMediaPiramide(n);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor no permitido");
                }
                    
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);

            } while (!salir);

        }
        public static void ImprimirMediaPiramide(int n)
        {
            int espacios = (n - 1);

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= espacios+(i+1); j++)                
                    if(j<=espacios)
                        Console.Write(" ");
                    else
                        Console.Write("#");
                
                Console.WriteLine();
                espacios--;
            }
        }
    }
}
