using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass2 = new int[15];
            Random rnd = new Random();
            
            for (int i=0;i<15;i++)
            {
                mass2[i] = rnd.Next(0, 50);
                
                Console.Write("|" + mass2[i] + "|");
            }

            int max = mass2[0];
            int min = mass2[0];
            foreach (int a in mass2)
            {
                {
                    if (a > max) max = a;
                    if (a <= min) min = a;

                }
            }
            
             Console.WriteLine();
            Console.WriteLine("Максимальное значение элемента  {0} минимальное значение элемента {1}", max, min) ;
            Console.WriteLine("Сумма максимального и минимального  элементов массива равна {0}", max + min);
            Console.ReadKey();
        }
    } 
}    
