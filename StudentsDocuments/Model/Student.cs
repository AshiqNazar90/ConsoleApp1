using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDocuments.Model
{
    public class Student
    {
        public int RollNum { get; set; }
        public string Name { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Total { get; set; }
        public int Avg { get; set; }

        public void ReadAllData()
        {
            Console.WriteLine("Enter Your Roll No:");
            RollNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Your Mark1");
            Mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Mark2");
            Mark2 = Convert.ToInt32(Console.ReadLine());

        }
        public void FindTotal()
        {
            Total = Mark1 + Mark2;
        }
        public void FindAvg()
        {
            Avg = Total / 2;
        }

        public void Display()

        {
            Console.WriteLine("Your Name is:"+Name);
            Console.WriteLine("Rollnumber is:" + RollNum);
            Console.WriteLine("Total is:" + Total);
            Console.WriteLine("Avg is:"+ Avg);
            Console.WriteLine("Successfully FIle Created");
        }
        public void FileWrite()
        {
            StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\Trainig\Testresult.txt");
            file.WriteLine("Your Name is:" + Name);
            file.WriteLine("Rollnumber is:" + RollNum);
            file.WriteLine("Total is:" + Total);
            file.WriteLine("Avg is:" + Avg);
            file.Close();
            Console.ReadKey();
        }
    }
}
