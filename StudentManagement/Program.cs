using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student obj = new Student();
            obj.rollno = 35;
            obj.name = "Ashiq";
            obj.schoolname = "MES";
            obj.m1 = 32;
            obj.m2 = 90;

            obj.FindSum();
            obj.DisplaySum();
        }
    }
}
