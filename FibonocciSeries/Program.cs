using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonocciSeries
{
        public class Fibonacci
        {
            public static void Main(string[] args)
            {
                int num1 = 0, num2 = 1, number;

                Console.WriteLine("Enter Number of elements you want\n");
                number = Convert.ToInt32(Console.ReadLine());
                Console.Write(num1 + " " + num2 + " ");
                for (int i = 2; i < number; i++)
                {
                    int num3 =num1 + num2;
                    Console.Write(num3 + " ");
                    num1 = num2;
                    num2 = num3;
                }
                Console.ReadLine();
            }
        }
}
