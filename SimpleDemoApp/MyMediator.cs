using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemoApp
{
    public class MyMediator
    {
        public delegate void MessageReceipted(string msg);
        public event MessageReceipted ClientMessageReceipted;
        public MyMediator()
        {
        }
        public void Send(string msg)
        {
            if (ClientMessageReceipted != null)
            {
                ClientMessageReceipted(msg);
            }
        }

    }
}
