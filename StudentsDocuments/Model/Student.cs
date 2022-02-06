using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
            Console.WriteLine("Your Name is:" + Name);
            Console.WriteLine("Rollnumber is:" + RollNum);
            Console.WriteLine("Total is:" + Total);
            Console.WriteLine("Avg is:" + Avg);
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

        public void MailSent()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("ashiqnazarss@gmail.com");


            mail.To.Add("hashidaashiq2020@gmail.com");
            mail.Subject = "Test Email";
            mail.Body = "Hello ";


            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ashiqnazarss@gmail.com", "ashioque1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            Console.WriteLine("succesfully Sent your Mail");
        }

        public void SendOtpmail(string toEmail)
        {
            //write code for creating random number
            //write code for email sending
            Random random = new Random();
            int OTP = random.Next(1000, 2000);

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("ashiqnazarss@gmail.com");


            mail.To.Add("khanashiq18@gmail.com");
            mail.Subject = "OTP";
            mail.Body = OTP.ToString();


            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ashiqnazarss@gmail.com", "ashioque1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            Console.WriteLine("succesfully OTP Sent your Mail");
        }
    }
}
