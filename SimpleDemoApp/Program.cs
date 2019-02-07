using System;

namespace SimpleDemoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyMediator myMediator = new MyMediator();
            Client Client1 = new Client(myMediator, "Client1");
            Client Client2 = new Client(myMediator,"Client2");
            //Console.WriteLine("Main: Instantiating two clients (Client 1 and Client 2) based on a single class template. There is a 3 second delay for the clients to process each event. ");
            
            Client1.Send();
            Client2.Send();
            Console.WriteLine("Main: Returning control to Main program");
            Console.ReadLine();


        }
    }
}
