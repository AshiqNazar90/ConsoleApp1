using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            String name;
            int Total;
            float Avg;
            Console.WriteLine("Enter your Name:\n");
            name = Console.ReadLine();
            Console.WriteLine("Enter your 1st mark:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your 2nd mark:");
            b= Convert.ToInt32(Console.ReadLine());
            Total = a + b;
            Avg = Total / 2;
            Console.WriteLine("Sum= {0} +{1} = {2}",a,b,Total);
            Console.WriteLine("Avg= {0}",Avg);
            Console.ReadKey();
        }
    }
}
