using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Введите число :  ");
            N = int.Parse (Console.ReadLine());
                        

            if (N % 2==1)
            {
                Console.WriteLine("Число нечетное");
            }
            else
            { 
                Console.WriteLine("Число четное");
            }
            Console.ReadKey();
        }
    }
}
