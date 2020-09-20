using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaParteUno
{
    class Matriz
    {
        private int [,] matriz;
        private int n;
        public Matriz(int n)
        {
            this.n = n;
            matriz = new int[n,n];
        }

        public void llenarAleatorio()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i,j] = random.Next(0, 100);
                }
            }
        }

        public void imprimirMatriz()
        {
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int diagonalPrincipal()
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma = suma + matriz[i, i];
            }
            return suma;
        }

        public int diagonalInvesa()
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma = suma + matriz[i, (n-1)-i];
            }
            return suma;
        }

        public int maximo()
        {
            int max = 0; // suponiendo que cero es el menor numero que tendremos
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j]>max)
                    {
                        max = matriz[i, j];
                    }
                }
            }
            return max;
        }

        public int minimo()
        {
            int min = 100; // suponiendo que 100 es el mayor numero que tendremos
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < min)
                    {
                        min = matriz[i, j];
                    }
                }
            }
            return min;
        }
    }
}
