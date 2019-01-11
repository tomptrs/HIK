using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    ////////////////
    // Oefening 1 //
    ////////////////    
    public abstract class Shape
    {
        public abstract double Opp();
    }

    class Circle : Shape
    {
        public int straal;
        public Circle(int s) { straal = s; }
        public override double Opp() { return straal * straal * Math.PI; }
    }

    class Square : Shape
    {
        public int lengte;
        public Square(int l) { lengte = l; }
        public override double Opp() { return lengte * lengte; }
    }

    class OppBerekenaar
    {
        List<Shape> lijst;
        WriteOutput _output;

        public OppBerekenaar(WriteOutput pOutput)
        {
            lijst = new List<Shape>();
            _output = pOutput;
        }

        public void VoegToe(Shape s) { lijst.Add(s); }

        private double Sum()
        {
            double total = 0.0;
            foreach (Shape s in lijst)
            {
                total += s.Opp();
            }
            return total;
        }

        public string Output()
        {
            //return "<h1> Totale som = " + Sum() + " </h1> ";
            return _output.Output("<h1> Totale som = " + Sum() + " </h1> ");
        }
    }

    public abstract class WriteOutput
    {
        public abstract string Output(string pMessage);
    }




    ////////////////
    // Oefening 2 //
    ////////////////    
    //class MySQLConnection
    //{
    //}

    abstract class DbConnection
    {
    }
    class PasswordReminder
    {
        //private MySQLConnectoin dbConnection;
        //public PasswordReminder(MySQLConnectoin con) { dbConnection = con; }

        private DbConnection dbConnection;
        public PasswordReminder(DbConnection con) { dbConnection = con; }
    }


    ////////////////
    // Oefening 3 //
    ////////////////
    public class InvitationService
    {
        private bool ValidateInput(string email, string firstName, string lastName)
        {
            bool rv = true;

            if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
            {
                Console.WriteLine("Name is not valid!");
                rv = false;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("Email is not valid!!");
                rv = false;
            }

            return rv;
        }
        public void SendInvite(string email, string firstName, string lastName)
        {
            if (ValidateInput(email, firstName, lastName))
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                client.Send(new System.Net.Mail.MailMessage("mysite@nowhere.com", email)
                {
                    Subject = "Please join me at my p"
                });
            }
        }
    }




    ////////////////
    // Oefening 4 //
    ////////////////
    public interface IMessage
    {
        IList<String> ToAddresses { get; set; }
        string MessageBody { get; set; }
        bool Send();
    }

    public interface IMailMessage
    {
        string Subject { get; set; }
        IList<String> BccAddresses { get; set; }
    }

    public class SmtpMessage : IMessage, IMailMessage
    {
        public IList<String> ToAddresses { get; set; }
        public IList<String> BccAddresses { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public bool Send()
        {
            //Do the real work here            
            return true;
        }
    }
    public class SmsMessage : IMessage
    {
        public IList<String> ToAddresses { get; set; }
        public string MessageBody { get; set; }

        public bool Send()
        {            
            //Do the real work here            
            return true;
        }
    }


    ////////////////
    // Oefening 5 //
    ////////////////
    public class Bird
    {
        public virtual void SetLocation(double longitude, double latitude)
        {
        }
        public virtual void SetAltitude(double altitude)
        {
        }
        public virtual void Draw()
        {
        }
    }



    ////////////////
    // Oefening 6 //
    ////////////////
    public enum Kleuren { geel, groen, blauw }
    public class Product { public string Naam { get; set; } public Kleuren Kleur { get; set; } public int Grootte { get; set; } }
    public class Filter
    {
        public List<Product> FilterMethod(List<Product> lijst, Kleuren kleur)
        {
            List<Product> tmp = new List<Product>();
            foreach (var p in lijst) { if (p.Kleur == kleur) tmp.Add(p); }
            return tmp;
        }
    }

}

