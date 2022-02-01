using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            int number, reverse = 0, reminder;
            Console.WriteLine("Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            while(number>0)
            {
                reminder = number % 10;
                reverse = reverse * 10 + reminder;
                number /= 10;
            }
            Console.WriteLine("Reversed Number: ",+ reverse);

        }
    }
}
