using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._1_Dvumer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размерность массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                int[,] mass = new int[n, m];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        mass[i, j] = r.Next(-50, 50);
                        Console.Write(mass[i, j] + "   ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 1; i < n; i = i + 2)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (mass[i, j] > 0)
                        {
                            Console.Write(mass[i, j] + "   ");
                        }
                    }
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadKey();
        }
    }
}
