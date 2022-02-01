using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StundentResult
{
    internal class Student
    {
        public int M1;
        public int M2;
        public int Total;
        public int Avg;
        public string Name;

        public void ReadFunction()
        {
            Console.WriteLine("Enter Your Name:");
            Console.ReadLine();
            Console.WriteLine("Enter your Mark1:");
            M1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Mark2: ");
            M2 = Convert.ToInt32(Console.ReadLine());
        }
        public void FindTotal()
        {
            Console.WriteLine("Your Total is:{0}", Total = M1 + M2);
        }
        public void FindAvg()
        {
            Console.WriteLine("Average:{0}", Avg = Total / 2);
        }
        public void Display()
        {
            Console.WriteLine("Mark1:{0}", M1);
            Console.WriteLine("Mark2: {0}", M2);
            Console.WriteLine("Total: {0}", Total);
            Console.WriteLine("Average:{0}", Avg);
        }
    }
}
