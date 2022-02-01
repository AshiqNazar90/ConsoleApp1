using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StundentResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ashiq=new Student();
            ashiq.ReadFunction();
            ashiq.FindTotal();
            ashiq.FindAvg();
            ashiq.Display();

            Student rinshad=new Student();
            rinshad.ReadFunction();
            rinshad.FindTotal();    
            rinshad.FindAvg();  
            rinshad.Display();



            Console.ReadKey();
        }
    }
}
