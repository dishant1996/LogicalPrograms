using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UC5_Coupon_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Taking_User_input
            Console.WriteLine("Enter number of coupons");
            int number = Convert.ToInt32(Console.ReadLine());   
            string coupons = string.Empty;
            while (number > 0)
            {
                int random = new Random().Next(1, 123);
                coupons = coupons + (char)random;
                number--;
            }
            Console.WriteLine($"Your coupon number is {coupons}");
            Console.ReadLine();
        }
    }
}
