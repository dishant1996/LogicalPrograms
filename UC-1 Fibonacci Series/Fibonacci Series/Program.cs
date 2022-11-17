using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=1, c,n,i;//Declared Variable
            Console.WriteLine("Enter The Number");
            n = Convert.ToInt32(Console.ReadLine());
            for ( i = 0; i < n; i++)
            {
                Console.Write($" {a} ");
                c = a + b;
                a = b;
                b = c; 
            }
            Console.ReadLine();
        }
    }
}
