using System;

namespace SimpleDemoApp
{
    public class Client
    {
        private MyMediator _myMediator;
        private string _message;
        public Client(MyMediator myMediator, string ClientName)
        {
             _myMediator = myMediator;
            _message = ClientName;
            _myMediator.ClientMessageReceipted += new MessageReceipted(Received);
         }

        public void Received(string msg)
        {
            Console.WriteLine($"{_message}: {msg}");
            Console.ReadLine();
        }

        public void Send()
        {
            _myMediator.Send(_message);
        }
    }
}
