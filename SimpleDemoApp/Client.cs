using System;
using System.Threading.Tasks;

namespace SimpleDemoApp
{
    public class Client
    {
        private MyMediator _myMediator;
        private string _clientName;
        public Client(MyMediator myMediator, string ClientName)
        {
             _myMediator = myMediator;
            _clientName = ClientName;
            _myMediator.ClientMessageReceipted += new MessageReceipted(ReceivedAsync);
         }

        public async void ReceivedAsync(string msg)
        {
            await Task.Delay(3000);
            Console.WriteLine($"{_clientName}: {msg}");
        }

        public void Send()
        {
            _myMediator.Send(_clientName);
        }
    }
}
