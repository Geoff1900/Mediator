using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyMediator myMediator = new MyMediator();
            Client Client1 = new Client(myMediator, "Client1");
            Client Client2 = new Client(myMediator,"Client2");
            Console.WriteLine("Hit [Enter] to View each event!");
            Console.ReadLine();
            Client1.Send();
            Client2.Send();


        }
    }
}
