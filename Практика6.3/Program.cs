using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mas[i, j] = random.Next(1, 4);
                }
            }
            int[] strSums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    strSums[i] += mas[i, j];
                }
            }
            int[] stolProducts = new int[10];
            for (int j = 0; j < 10; j++)
            {
                stolProducts[j] = 1;
                for (int i = 0; i < 10; i++)
                {
                    stolProducts[j] *= mas[i, j];
                }
            }
            int maxSum = strSums.Max();
            int maxProiz = stolProducts.Max();
            Console.WriteLine("Сумма элементов каждой строки:");
            foreach (int sum in strSums)
            {
                Console.WriteLine(sum);
            }
            Console.WriteLine("Произведение элементов каждого столбца:");
            foreach (int product in stolProducts)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("Наибольшая сумма: " + maxSum);
            Console.WriteLine("Наибольшее произведение: " + maxProiz);
        }
    }
}
