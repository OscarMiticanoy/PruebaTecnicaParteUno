
using System;

namespace PruebaTecnicaParteUno
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz m;
            int n;
            Console.WriteLine("Matriz de nxn");
            Console.WriteLine("valor de n: ");
            n = int.Parse(Console.ReadLine());
            if ( n>=0 && n <= 100 )
            {
                m = new Matriz(n);
                m.llenarAleatorio();
                Console.WriteLine("\n\nMatriz actual\n");
                m.imprimirMatriz();
                Console.WriteLine("\n\nResultados obtenidos\n");
                Console.WriteLine("La diagonal principal suma "+m.diagonalPrincipal()+"\n");
                Console.WriteLine("La diagonal inversa suma " + m.diagonalInvesa() + "\n");
                Console.WriteLine("El numero maximo es " + m.maximo() + "\n");
                Console.WriteLine("El numero minimo es  " + m.minimo() + "\n");
            }
            else
            {
                Console.WriteLine("valor de n debe estar en el rango 0 - 100");
            }
        }
    }
}
