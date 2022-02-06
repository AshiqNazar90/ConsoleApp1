using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        public int rollno;
        public string name;
        public string schoolname;
        public int m1;
        public int m2;
        public int sum;

        public void FindSum()
        {

            sum = m1 + m2;
        }

        public void DisplaySum()
        {
            Console.WriteLine(name);
            Console.WriteLine(schoolname);
            Console.WriteLine(rollno);
            Console.WriteLine("Sum:={0}", sum);
            Console.ReadKey();  
        }
    }
}
