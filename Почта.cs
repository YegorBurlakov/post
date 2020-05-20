using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace post
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Address");
            string adress = Console.ReadLine();
            Console.WriteLine("Your name");
            string name = Console.ReadLine();
            MailAddress from = new MailAddress(adress, name);
            Console.WriteLine("Recipient address");
            string adress_2 = Console.ReadLine();
            MailMessage objectMail = new MailMessage(adress, adress_2);
            Console.WriteLine("Theme");
            string tema = Console.ReadLine();
            objectMail.Subject = tema;
            Console.WriteLine("Text");
            string text = Console.ReadLine();
            objectMail.Body = text;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            Console.WriteLine("Your gmail");
            string gmail = Console.ReadLine();
            Console.WriteLine("Password");
            string password = Console.ReadLine();
            smtp.Credentials = new NetworkCredential(gmail, password);
            smtp.EnableSsl = true;
            smtp.Send(objectMail);
            Console.Read();
        }
    }
}


