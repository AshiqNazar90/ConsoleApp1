using StudentsDocuments.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDocuments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            // obj.ReadAllData();
            //obj.FindTotal();
            //obj.FindAvg();
            // obj.Display();
            //obj.FileWrite();
            // obj.MailSent();
            obj.SendOtpmail("success");
            Console.ReadKey();

        }
    }
}
