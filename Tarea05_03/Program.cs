using System;

namespace Tarea05_03
{


    class Program
    {
        static Boolean esPrimo(int numero)
        {
            Boolean resultado = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero%i == 0)
                {
                    resultado = false;
                }

            }
            return resultado;
        }


        static void Main(string[] args)
        {
            Console.Write("Introduce un número para determinar si es primo: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Boolean primo = esPrimo(num); 

            if (primo)
            {
                Console.Write("El número {0} es Primo.", num);
            }
            else
            {
                Console.Write("El número {0} NO es Primo.", num);
            }

            Console.ReadKey();
        }
    }
}
