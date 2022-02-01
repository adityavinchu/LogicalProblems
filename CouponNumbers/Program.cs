using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponNumbers
{
    public class CouponNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Unique Coupons That You Want\n");
            int n = Convert.ToInt32(Console.ReadLine());
            HashSet<int> numbers = new HashSet<int>();
            bool flag = true;
            int ans = 0;
            Random random = new Random();
            while (flag)
            {
                int coupon = random.Next(1, 500);
                Console.WriteLine(coupon);
                if (!numbers.Contains(coupon))
                {
                    ans++;
                    numbers.Add(coupon);

                }
                if (ans == n) break;
            }
            Console.Write("Total Random Number Needed to Generate {0} Unique coupons ", n);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
