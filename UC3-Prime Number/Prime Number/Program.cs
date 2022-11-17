using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //local Variable
            int num,i, count=0;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)//Condition check
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not Prime Number");
            Console.ReadLine(); 
        }
    }
}
