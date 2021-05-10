using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utwórz tablicę dwuwymiarową, w której liczba komórek w kolejnych rzędach będzie równa dziesięciu kolejnym 
            //wartościom ciągu Fibonacciego, poczynając od elementu o wartości 1(1, 1, 2, 3, 5 itd.).Wartość każdej 
            //komórki powinna być jej numerem w danym wierszu w kolejności malejącej(czyli dla wiersza o długości pięciu
            //komórek kolejne wartości to 5, 4, 3, 2, 1). Zawartość tablicy wyświetl na ekranie

            //talica z liczbami fibonaciego
            int[] fibonaci = new int[10];
            fibonaci[0] = 1;
            fibonaci[1] = 1;
            for (int i = 2; i < 10; i++)
            {
                fibonaci[i] = fibonaci[i - 1] + fibonaci[i - 2];
            }

            //tablica tablic
            int[][] postrzepiona = new int[10][];

            for (int i = 0; i < postrzepiona.Length; i++)
            {
                postrzepiona[i] = new int[fibonaci[i]];
                int liczba = postrzepiona[i].Length;

                Console.Write("tab[{0}] = ", i);
                for (int j = 0; j < postrzepiona[i].Length; j++)
                {
                    postrzepiona[i][j] = liczba--;
                    Console.Write("{0} ", postrzepiona[i][j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
