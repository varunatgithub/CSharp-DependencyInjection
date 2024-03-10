using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DependencyInjection
{
    public class WhatsAppSender : IMessageSender
    {
        // This is yet another implementation of the interface
        public void SendMessage(string message, string recipient)
        {
            // Code to send a WhatsApp message
            Console.WriteLine($"Hi {recipient}, {message}");
        }
    }
}
