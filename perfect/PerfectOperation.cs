using System;

namespace perfect
{
    internal class PerfectOperation
    {

        int i, sum;
        int num;
        public void Perfect()
        {
            Console.Write("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            i = 1;
            sum = 0;
            while (i < num)
            {
                if (num % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == num)
                Console.Write("{0} is Perfect Number", num);
            else
                Console.WriteLine("this is NOT perfect number ");

            Console.Write("\n");
        }
    }
}