using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum=0;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)//calculate the factors
                {
                    Console.WriteLine($"Factors ={i}");
                    sum += i;   //addition of factors
                }
               
            }
            Console.WriteLine($"{$"{sum} == {num}"}");
            if (sum == num)//Check sum value and Enter Value
                Console.WriteLine("\nPerfect Number");
            else
                Console.WriteLine("Not Perfrct Number");
            Console.ReadLine();
        }
    }
}
