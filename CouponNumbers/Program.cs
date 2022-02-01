
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponNumbers
{
    public class CoupanNumber
    {
        public void GenerateCoupon()
        {
            Console.WriteLine("Enter the Number of Unique Coupans That You Want\n");
            int num = Convert.ToInt32(Console.ReadLine());
            HashSet<int> numbers = new HashSet<int>();
            bool flag = true;
            int ans = 0;
            Random random = new Random();
            while (flag)
            {
                int coupan = random.Next(1, 500);
                Console.WriteLine(coupan);
                if (!numbers.Contains(coupan))
                {
                    ans++;
                    numbers.Add(coupan);

                }
                if (ans == num) break;
            }
            Console.Write("Total Numbers Needed to Generate {0} Unique coupans ", num);
            Console.WriteLine(ans);

        }
    }
}
