using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DependencyInjection
{
    public class SmsSender : IMessageSender
    {
        // This is another implementation of the interface
        public void SendMessage(string message, string recipient)
        {
            // Code to send an SMS
            Console.WriteLine($"Hi {recipient}, {message}");
        }
    }
}
