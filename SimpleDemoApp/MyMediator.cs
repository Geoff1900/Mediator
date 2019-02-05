using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDemoApp
{
    public delegate void MessageReceipted(string msg);
    
public class MyMediator
    {
        
        public event MessageReceipted ClientMessageReceipted;
        
        public MyMediator()
        {
        }
        
        public void Send(string msg)
        {
            if (ClientMessageReceipted != null)
            {
                ClientMessageReceipted($"This message is coming from {msg}");
            }
        }

    }
}
