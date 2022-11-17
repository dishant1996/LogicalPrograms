using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_Reverse_number
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Variable Declare
            int num;
            int reverse = 0;

            Console.WriteLine("Enter the number : ");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                reverse = reverse * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine($"Reversed number {reverse}");
            Console.ReadLine();
           
        }   
    }   
}
