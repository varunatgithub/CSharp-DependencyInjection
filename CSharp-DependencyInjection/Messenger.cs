using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DependencyInjection
{
    public class Messenger
    {
        // This is the object that actually sends the messages
        private EmailSender _emailSender = new EmailSender();

        // This is the method that uses the email sender
        public void SendMessage(string message, string recipient)
        {
            _emailSender.SendMessage(message, recipient);
        }
    }
}
