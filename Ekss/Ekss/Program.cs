using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double y1 = 0;
            //double y2 = 0;
            //double x = -5;
            //Console.WriteLine("");
            //int a =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");
            //int c = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    if (x != 1)
            //    {
            //        y1 = a * x * x + b * x + c;
            //        y2 = 1 / (x-1);
            //        if (((decimal )y1) == ((decimal)y2))
            //        {
            //            Console.WriteLine($"{y1}   {y2} {x}");
            //            // Console.ReadKey();
            //        }
            //    }
            //   x += 0.001;

            //} while (x!=5);
            //Console.WriteLine(" Точек соединения нет ");
            //Console.ReadKey();

            Console.WriteLine();
            int N = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[,] matr = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matr[i, j] = random.Next(-5, 5);
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"   {matr[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"   {matr[i, j] * N}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
